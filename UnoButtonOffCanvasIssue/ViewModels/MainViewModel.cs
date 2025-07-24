
namespace UnoButtonOffCanvasIssue.ViewModels;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainViewModel : INotifyPropertyChanged
{
    private int hitNo;

    public MainViewModel() 
    {
        this.ZoomX = 2.0;
        this.ZoomY = 2.0;
        this.BX = 198;
        this.BY = 198;
        this.XY = string.Empty;
        this.BXBY = string.Empty;
        this.Monitor = "No hits";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public double BX { get; private set; }

    public double BY { get; private set; }

    public double X { get; private set; }

    public double Y { get; private set; }

    public string XY { get; private set; }

    public string BXBY { get; private set; }

    public double ZoomX { get; private set; }

    public double ZoomY { get; private set; }

    public string Monitor { get; private set; }

    public bool Show { get; private set; }

    public void SetContainerSize(double width, double height)
    {
        this.BX = (width / 3.0) - 4;
        this.BY = (height / 3.0) - 4;
        this.X = (width / 3.0);
        this.Y = -(height / 3.0);
        this.XY = this.CoordsAsString(this.X, this.Y);
        this.BXBY = this.CoordsAsString(this.BX, this.BY);
        this.OnPropertyChanged(nameof(this.X));
        this.OnPropertyChanged(nameof(this.Y));
        this.OnPropertyChanged(nameof(this.BX));
        this.OnPropertyChanged(nameof(this.BY));
        this.OnPropertyChanged(nameof(this.XY));
        this.OnPropertyChanged(nameof(this.BXBY));
    }

    public void ShowControl()
    {
        this.Show = true;
        this.OnPropertyChanged(nameof(this.Show));
    }

    public void DoAction()
    {
        this.Monitor = $"{++this.hitNo} hits";
        this.OnPropertyChanged(nameof(this.Monitor));
    }

    private string CoordsAsString(double x, double y)
    {
        return $"{x:#.00}, {y:#.00}";
    }

    private void OnPropertyChanged(string property)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
