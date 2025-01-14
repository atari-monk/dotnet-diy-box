﻿using DiyBox.Core;
using Xunit;

namespace DiyBox.Tests;

public class Size3dParserTests
{
	[Theory]
	[InlineData(new object[] {
		new string[] { null! } })]
	[InlineData(new object[] {
		new string[] { "" } })]
	[InlineData(new object[] {
		new string[] { "20" } })]
	[InlineData(new object[] {
		new string[] { "20", "10" } })]
	[InlineData(new object[] {
		new string[] { "20", "10", "5", "20" } })]
	public void Invalid_number_of_args_throws(
		string[] args)
	{
		var sut = new Size3dParser();

		var ex = Assert.Throws<ArgumentException>(
			"args"
			, () => sut.Parse(args));
		Assert.Equal(
			string.Join(
				" "
				, "Three args required"
				, "(Parameter 'args')"
			)
			, ex.Message);
	}

	[Theory]
	[InlineData(new object[] {
		new string[] { "a", "10", "5" }
		, "Length"})]
	[InlineData(new object[] {
		new string[] { "20", "a", "5" }
		, "Height"})]
	[InlineData(new object[] {
		new string[] { "20", "10", "a" }
		, "Depth"})]
	public void Input_invalid_format_throws(
		string[] args
		, string argName)
	{
		var sut = new Size3dParser();

		var ex = Assert.Throws<ArgumentException>(
			argName
			, () => sut.Parse(args));
		Assert.Equal(
			string.Join(
				" "
				, "Wrong format of arg"
				, $"(Parameter '{argName}')"
			)
			, ex.Message);
	}

	[Theory]
	[InlineData(new object[] {
		new string[] { "0.1", "0.1", "0.1" }
		, 0.1
		, 0.1
		, 0.1 })]
	[InlineData(new object[] { 
		new string[] { "20", "10", "5" }
		, 20
		, 10
		, 5 })]
	public void Valid_input_produces_parsed_data(
		string[] args
		, double length
		, double height
		, double depth)
	{
		var size = new Size3d(length, height, depth);
		var sut = new Size3dParser();

		var acctual = sut.Parse(args);

		Assert.Equal(size, acctual);
	}
}