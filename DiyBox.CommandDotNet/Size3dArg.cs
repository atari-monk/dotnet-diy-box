﻿using System.ComponentModel.DataAnnotations;
using CommandDotNet;

namespace DiyBox.CommandDotNet;

public class Size3dArg 
    : IArgumentModel
{
    private const string DimError = "Dimention must be greater than zero";
    
    [Operand(nameof(Length)), Required, Range(0.1, double.MaxValue, ErrorMessage = DimError)]
    public double Length { get; set; }

    [Operand(nameof(Height)), Required, Range(0.1, double.MaxValue, ErrorMessage = DimError)]
	public double Height { get; set; }
    
    [Operand(nameof(Depth)), Required, Range(0.1, double.MaxValue, ErrorMessage = DimError)]
	public double Depth { get; set; }
}