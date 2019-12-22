Imports System.Drawing.Imaging
Imports System.Threading
Imports System.Runtime.InteropServices.Marshal

''' <summary>
''' 最近傍補間法のロジック
''' </summary>
Public Class ScaleNearestNeighbor
    Private m_bitmap As Bitmap
    Private m_progressBar As ProgressBar

    ''' <summary>
    ''' ビットマップ
    ''' </summary>
    Public ReadOnly Property bitmap() As Bitmap
        Get
            Return m_bitmap.Clone()
        End Get
    End Property

    ''' <summary>
    ''' プログレスバー
    ''' </summary>
    Public WriteOnly Property progressBar() As ProgressBar
        Set(value As ProgressBar)
            m_progressBar = value
        End Set
    End Property

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="_progressBar">プログレスバー</param>
    Public Sub New(_progressBar As ProgressBar)
        m_progressBar = _progressBar
    End Sub

    ''' <summary>
    ''' 初期化
    ''' </summary>
    Public Sub Init()
        m_bitmap = Nothing
    End Sub

    ''' <summary>
    ''' 最近傍補間法の実行
    ''' </summary>
    ''' <param name="_bitmap">ビットマップ</param>
    ''' <param name="_fScale">スケール</param>
    ''' <param name="_token">キャンセルトークン</param>
    ''' <param name="_form">フォーム</param>
    ''' <returns>実行結果 成功/失敗</returns>
    Public Function GoImgProc(_bitmap As Bitmap, _fScale As Single, _token As CancellationToken, _form As Form) As Boolean
        Dim bRst As Boolean = True

        Dim nWidthSize As Integer = CInt(_bitmap.Width * _fScale)
        Dim nHeightSize As Integer = CInt(_bitmap.Height * _fScale)

        m_bitmap = New Bitmap(nWidthSize, nHeightSize)

        Dim bitmapDataOrg As BitmapData = _bitmap.LockBits(New Rectangle(0, 0, _bitmap.Width, _bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb)
        Dim bitmapDataAfter As BitmapData = m_bitmap.LockBits(New Rectangle(0, 0, m_bitmap.Width, m_bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb)

        Dim nIdxWidth As Integer
        Dim nIdxHeight As Integer
        Dim nCount As Integer = 0

        For nIdxHeight = 0 To nHeightSize - 1 Step 1
            If (_token.IsCancellationRequested = True) Then
                bRst = False
                Exit For
            End If

            For nIdxWidth = 0 To nWidthSize - 1 Step 1
                If (_token.IsCancellationRequested = True) Then
                    bRst = False
                    Exit For
                End If

                Dim nWidth As Integer = CInt(Math.Round(nIdxWidth / _fScale))
                Dim nHeight As Integer = CInt(Math.Round(nIdxHeight / _fScale))

                If (nWidth < _bitmap.Width And nHeight < _bitmap.Height) Then
                    Dim pAdrOrg As IntPtr = bitmapDataOrg.Scan0
                    Dim nPosOrg As Integer = nHeight * bitmapDataOrg.Stride + nWidth * 4
                    Dim pAdrAfter As IntPtr = bitmapDataAfter.Scan0
                    Dim nPosAfter As Integer = nIdxHeight * bitmapDataAfter.Stride + nIdxWidth * 4
                    WriteByte(pAdrAfter, nPosAfter + ComInfo.Pixel.B, ReadByte(pAdrOrg, nPosOrg + ComInfo.Pixel.B))
                    WriteByte(pAdrAfter, nPosAfter + ComInfo.Pixel.G, ReadByte(pAdrOrg, nPosOrg + ComInfo.Pixel.G))
                    WriteByte(pAdrAfter, nPosAfter + ComInfo.Pixel.R, ReadByte(pAdrOrg, nPosOrg + ComInfo.Pixel.R))
                    WriteByte(pAdrAfter, nPosAfter + ComInfo.Pixel.A, ReadByte(pAdrOrg, nPosOrg + ComInfo.Pixel.A))

                    nCount = nCount + 1
                End If
            Next
            If (m_progressBar IsNot Nothing And _form IsNot Nothing) Then
                _form.Invoke(New Action(Of Integer)(AddressOf SetProgressBar), nCount)
            End If
        Next
        _bitmap.UnlockBits(bitmapDataOrg)
        m_bitmap.UnlockBits(bitmapDataAfter)

        Return bRst
    End Function

    ''' <summary>
    ''' プログレスバーの設定
    ''' </summary>
    ''' <param name="_nCount">カウント</param>
    Private Sub SetProgressBar(_nCount As Integer)
        m_progressBar.Value = _nCount
    End Sub
End Class
