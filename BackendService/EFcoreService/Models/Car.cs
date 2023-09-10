using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcoreService.Models;
public class Car
{
    public string CarNo { get; set; } = "";
    public double Lat { get; set; } = 0;
    public double Lon { get; set; } = 0;
    // 0未出租 1出租
    public Int16 Status { get; set; } = 0;
}
