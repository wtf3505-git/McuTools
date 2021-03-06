//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Media.Media3D;


namespace McuTools.Interfaces.Effects
{

    /// <summary>A transition effect </summary>
    public class OpacityFadeEffect : ShaderEffect
    {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(OpacityFadeEffect), 0);
        public static readonly DependencyProperty ProgressProperty = DependencyProperty.Register("Progress", typeof(double), typeof(OpacityFadeEffect), new UIPropertyMetadata(((double)(30D)), PixelShaderConstantCallback(0)));
        public static readonly DependencyProperty FuzzyAmountProperty = DependencyProperty.Register("FuzzyAmount", typeof(double), typeof(OpacityFadeEffect), new UIPropertyMetadata(((double)(0.05D)), PixelShaderConstantCallback(4)));
        public OpacityFadeEffect()
        {
            PixelShader pixelShader = new PixelShader();
            pixelShader.UriSource = new Uri("/MCUTools.Interfaces;component/Effects/OpacityFadeEffect.ps", UriKind.Relative);
            this.PixelShader = pixelShader;

            this.UpdateShaderValue(InputProperty);
            this.UpdateShaderValue(ProgressProperty);
            this.UpdateShaderValue(FuzzyAmountProperty);
        }
        public Brush Input
        {
            get
            {
                return ((Brush)(this.GetValue(InputProperty)));
            }
            set
            {
                this.SetValue(InputProperty, value);
            }
        }
        /// <summary>The amount(%) of the transition from first texture to the second texture. </summary>
        public double Progress
        {
            get
            {
                return ((double)(this.GetValue(ProgressProperty)));
            }
            set
            {
                this.SetValue(ProgressProperty, value);
            }
        }
        public double FuzzyAmount
        {
            get
            {
                return ((double)(this.GetValue(FuzzyAmountProperty)));
            }
            set
            {
                this.SetValue(FuzzyAmountProperty, value);
            }
        }
    }
}
