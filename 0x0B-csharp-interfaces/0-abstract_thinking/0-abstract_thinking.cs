using System;

/// <summary>
/// Abstract class Base
/// </summary>
abstract class Base
{
  public string name;

  /// <summary>
  /// Function ToString override
  /// </summary>
  /// <returns> returns a new string with name and its type</returns>
  public override string ToString() => $"{name} is a {this.GetType()}";
}
