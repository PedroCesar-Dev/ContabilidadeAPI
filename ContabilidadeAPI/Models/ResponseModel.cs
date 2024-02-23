using System.ComponentModel.DataAnnotations;

namespace ContabilidadeAPI.Models;
public class ResponseModel
{
    public bool Success { get; set; } = true;
    public string? Message { get; set; }
    public object? Data { get; set; }
}
