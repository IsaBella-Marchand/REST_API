using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
public class Employe
{
    public long id { get; set; }
    public string name { get; set; }
    public string firstName { get; set; }
    public string title { get; set; }
    public string email { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }
    public long user_id { get; set; }
}
