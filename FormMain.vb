Imports System.Threading

''' <summary>
''' MainFormのロジック
''' </summary>
Public Class FormMain
    Private m_mousePoint As Point
    Private m_strOpenFileName As String
    Private m_scaleImgProc As ScaleNearestNeighbor
    Private m_tokenSource As CancellationTokenSource

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        m_scaleImgProc = New ScaleNearestNeighbor(progressBar)

        labelValue.Text = "1"
        btnSaveImage.Enabled = False
    End Sub

    ''' <summary>
    ''' タイトルバーマウスダウンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnMouseDownLblTitle(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            m_mousePoint = New Point(e.X, e.Y)
        End If

        Return
    End Sub

    ''' <summary>
    ''' タイトルバーマウスムーブのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnMouseMoveLblTitle(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseMove
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            Me.Left += e.X - m_mousePoint.X
            Me.Top += e.Y - m_mousePoint.Y
        End If

        Return
    End Sub

    ''' <summary>
    ''' ファイル選択ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnFileSelect(sender As Object, e As EventArgs) Handles btnFileSelect.Click
        Dim openFileDlg As ComOpenFileDialog = New ComOpenFileDialog()
        openFileDlg.Filter = "JPG|*.jpg|PNG|*.png"
        openFileDlg.Title = "Open the file"
        If (openFileDlg.ShowDialog() = True) Then
            pictureBox.Image = Nothing
            m_strOpenFileName = openFileDlg.FileName
            pictureBox.ImageLocation = m_strOpenFileName
            lblSelectFileName.Text = m_strOpenFileName
            m_scaleImgProc.Init()
        End If
    End Sub

    ''' <summary>
    ''' 閉じるボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnClose(sender As Object, e As EventArgs) Handles btnClose.Click, btnCloseIcon.Click
        Dim result As DialogResult = MessageBox.Show("Close the application ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
        If (result = DialogResult.OK) Then
            Me.Close()
        End If

        Return
    End Sub

    ''' <summary>
    ''' 初期化ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnInit(sender As Object, e As EventArgs) Handles btnInit.Click
        If (Not String.IsNullOrWhiteSpace(m_strOpenFileName)) Then
            pictureBox.ImageLocation = m_strOpenFileName
        End If
        m_scaleImgProc.Init()
        btnSaveImage.Enabled = False
    End Sub

    ''' <summary>
    ''' スケールのスライダーのスクロールイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnScrollSliderScale(sender As Object, e As EventArgs) Handles sliderScale.Scroll
        labelValue.Text = (sliderScale.Value * 0.1).ToString()

        Return
    End Sub

    ''' <summary>
    ''' 最近傍補間法実行ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Async Sub OnClickBtnGo(sender As Object, e As EventArgs) Handles btnGo.Click
        If (String.IsNullOrWhiteSpace(m_strOpenFileName)) Then
            Return
        End If

        btnFileSelect.Enabled = False
        btnSaveImage.Enabled = False
        btnInit.Enabled = False
        btnClose.Enabled = False
        btnCloseIcon.Enabled = False
        sliderScale.Enabled = False
        btnGo.Enabled = False

        progressBar.Value = 0
        progressBar.Minimum = 0
        Dim fScale = CSng(sliderScale.Value * 0.1)
        Dim bitmap As Bitmap = New Bitmap(m_strOpenFileName)
        Dim nWidth As Integer = CInt(bitmap.Width * fScale)
        Dim nHeight As Integer = CInt(bitmap.Height * fScale)
        progressBar.Maximum = nWidth * nHeight

        pictureBox.Image = Nothing

        Dim bResult As Boolean = Await TaskWorkImageProcessing(bitmap)
        If (bResult) Then
            pictureBox.Image = m_scaleImgProc.bitmap
            btnSaveImage.Enabled = True
        Else
            pictureBox.ImageLocation = m_strOpenFileName
        End If

        btnFileSelect.Enabled = True
        btnInit.Enabled = True
        btnClose.Enabled = True
        btnCloseIcon.Enabled = True
        sliderScale.Enabled = True
        btnGo.Enabled = True

        bitmap.Dispose()

        Return
    End Sub

    ''' <summary>
    ''' 画像処理実行用のタスク
    ''' </summary>
    ''' <returns>画像処理の実行結果 成功/失敗</returns>
    Public Function TaskWorkImageProcessing(_bitmap As Bitmap)
        m_tokenSource = New CancellationTokenSource()
        Dim token As CancellationToken = m_tokenSource.Token
        Dim fScale As Single = CSng(sliderScale.Value * 0.1)
        Dim bRst As Task(Of Boolean) = Task.Run(Function() m_scaleImgProc.GoImgProc(_bitmap.Clone(), fScale, token, Me))
        Return bRst
    End Function

    ''' <summary>
    ''' イメージの保存ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnSaveImage(sender As Object, e As EventArgs) Handles btnSaveImage.Click
        Dim saveDialog As ComSaveFileDialog = New ComSaveFileDialog()
        saveDialog.Filter = "PNG|*.png"
        saveDialog.Title = "Save the file"
        If (saveDialog.ShowDialog() = True) Then
            Dim strFileName = saveDialog.FileName
            Dim bitmap = m_scaleImgProc.bitmap
            If (bitmap IsNot Nothing) Then
                Try
                    bitmap.Save(strFileName, System.Drawing.Imaging.ImageFormat.Png)
                Catch ex As Exception
                    MessageBox.Show(Me, "Save Image File Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                bitmap.Dispose()
            End If

            Return
        End If
    End Sub

    ''' <summary>
    ''' ストップボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnStop(sender As Object, e As EventArgs) Handles btnStop.Click
        If (m_tokenSource IsNot Nothing) Then
            m_tokenSource.Cancel()
        End If

        Return
    End Sub

    ''' <summary>
    ''' 最小化ボタンのクリックイベント
    ''' </summary>
    ''' <param name="sender">オブジェクト</param>
    ''' <param name="e">イベントのデータ</param>
    Private Sub OnClickBtnMinimizedIcon(sender As Object, e As EventArgs) Handles btnMinimizedIcon.Click
        Me.WindowState = FormWindowState.Minimized

        Return
    End Sub

End Class