using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private TextBlock selectedFigure;
        private Grid selectedFigureCell;

        public MainPage()
        {
            this.InitializeComponent();

            SolidColorBrush whiteBoardBrush = new SolidColorBrush(Colors.BurlyWood);
            SolidColorBrush blackBoardBrush = new SolidColorBrush(Colors.Peru);

            for (int i = 0; i < 8; i++)
            {
                ColumnDefinition columnDefinition = new ColumnDefinition();
                columnDefinition.Width = new GridLength(50);
                RowDefinition rowDefinition = new RowDefinition();
                rowDefinition.Height = new GridLength(50);

                ChessBoard.ColumnDefinitions.Add(columnDefinition);
                ChessBoard.RowDefinitions.Add(rowDefinition);
            }

            // Init black board
            bool isWhite = true;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Grid cell = new Grid();
                    cell.Visibility = Visibility.Visible;
                    cell.PointerPressed += new PointerEventHandler(OnCellPointerPressedHandler);

                    if (isWhite)
                    {
                        cell.Background = whiteBoardBrush;
                        ChessBoard.Children.Add(cell);
                    }
                    else
                    {
                        cell.Background = blackBoardBrush;
                        ChessBoard.Children.Add(cell);
                    }

                    isWhite = !isWhite;


                    Grid.SetColumn(cell, col);
                    Grid.SetRow(cell, row);
                }
                isWhite = !isWhite;
            }

            // Init figures
            // pawns
            foreach (Grid cell in ChessBoard.Children)
            {
                int row = Grid.GetRow(cell);
                int col = Grid.GetColumn(cell);

                switch (row)
                {
                    case 0:
                        // Add black figures without pawns
                        AddFigures(cell, (GameEngine.BoardColumn)col, GameEngine.FigureColor.Black);
                        break;
                    case 1:
                        // Add black pawn
                        AddFigure(cell, GameEngine.FigureType.Pawn, GameEngine.FigureColor.Black);
                        break;
                    case 6:
                        // Add white pawn
                        AddFigure(cell, GameEngine.FigureType.Pawn, GameEngine.FigureColor.White);
                        break;
                    case 7:
                        // Add white figures without pawns
                        AddFigures(cell, (GameEngine.BoardColumn)col, GameEngine.FigureColor.White);
                        break;
                }
            }

            DebugConsole.FontSize = 16;
            DebugConsole.TextWrapping = TextWrapping.Wrap;
            DebugConsole.Text = "This is test";

        }

      

        private void AddFigures(Grid cell, GameEngine.BoardColumn boardColumn, GameEngine.FigureColor figureColor)
        {
            switch (boardColumn)
            {
                case GameEngine.BoardColumn.A:
                    AddFigure(cell, GameEngine.FigureType.Rook, figureColor);
                    break;
                case GameEngine.BoardColumn.B:
                    AddFigure(cell, GameEngine.FigureType.Knight, figureColor);
                    break;
                case GameEngine.BoardColumn.C:
                    AddFigure(cell, GameEngine.FigureType.Bishop, figureColor);
                    break;
                case GameEngine.BoardColumn.D:
                    AddFigure(cell, GameEngine.FigureType.Queen, figureColor);
                    break;
                case GameEngine.BoardColumn.E:
                    AddFigure(cell, GameEngine.FigureType.King, figureColor);
                    break;
                case GameEngine.BoardColumn.F:
                    AddFigure(cell, GameEngine.FigureType.Bishop, figureColor);
                    break;
                case GameEngine.BoardColumn.G:
                    AddFigure(cell, GameEngine.FigureType.Knight, figureColor);
                    break;
                case GameEngine.BoardColumn.H:
                    AddFigure(cell, GameEngine.FigureType.Rook, figureColor);
                    break;
            }
        }

        private void AddFigure(Grid cell, GameEngine.FigureType figureType, GameEngine.FigureColor figureColor)
        {
            TextBlock tb = new TextBlock();

            switch (figureColor)
            {
                case GameEngine.FigureColor.White:
                    tb.Foreground = new SolidColorBrush(Colors.White);
                    break;
                case GameEngine.FigureColor.Black:
                    tb.Foreground = new SolidColorBrush(Colors.Black);
                    break;
                default:
                    throw new Exception("NEED TO SPECIFY BRUSH COLOR!!!!");
            }


            String figure = "";
            switch (figureType)
            {
                case GameEngine.FigureType.Pawn:
                    figure = "\u2659";
                    break;
                case GameEngine.FigureType.King:
                    figure = "\u2654";
                    break;
                case GameEngine.FigureType.Bishop:
                    figure = "\u2657";
                    break;
                case GameEngine.FigureType.Queen:
                    figure = "\u2655";
                    break;
                case GameEngine.FigureType.Rook:
                    figure = "\u2656";
                    break;
                case GameEngine.FigureType.Knight:
                    figure = "\u2658";
                    break;
                default:
                    throw new Exception("NO SUCH FIGURE EXIST!");
            }

            tb.FontSize = 42;
            tb.FontFamily = new Windows.UI.Xaml.Media.FontFamily("Tahoma");
            tb.FontWeight = FontWeights.Bold;
            tb.HorizontalAlignment = HorizontalAlignment.Center;
            tb.VerticalAlignment = VerticalAlignment.Center;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Text = figure;            
            tb.PointerPressed += new PointerEventHandler(OnFigurePointerPressedHandler);
            //tb.PointerReleased += new PointerEventHandler(OnFigurePointerReleasedHandler);
            cell.Children.Add(tb);
        }

        private void OnFigurePointerReleasedHandler(object sender, PointerRoutedEventArgs e)
        {
            //TextBlock tb = e.OriginalSource as TextBlock;
            //tb.FontWeight = FontWeights.Bold;
        }

        private void OnFigurePointerPressedHandler(object sender, PointerRoutedEventArgs e)
        {
            selectedFigure = e.OriginalSource as TextBlock;
            selectedFigure.FontWeight = FontWeights.Light;
            selectedFigureCell = (Grid)selectedFigure.Parent;
            e.Handled = true;
        }

        private void OnCellPointerPressedHandler(object sender, PointerRoutedEventArgs e)
        {
            if (selectedFigure != null)
            {
                Grid cell = e.OriginalSource as Grid;
                selectedFigureCell.Children.Remove(selectedFigure);
                cell.Children.Add(selectedFigure);
                selectedFigure.FontWeight = FontWeights.Bold;

                selectedFigure = null;
                selectedFigureCell = null;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
