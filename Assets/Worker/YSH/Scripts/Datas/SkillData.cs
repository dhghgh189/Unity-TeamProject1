using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillData : IDataLoader
{
    public int ID;
    public string Name;
    public string Description;
    public Enums.SkillType SkillType;
    public Enums.Grade Grade;
    public float Damage;                // ���
    public int CoolTime;
    public int Price;
    public int Radius;                  // ���� ����
    public string ClassName;
    public int Second;                  // ��Ʈ ������ ��
    public float Tick;                  // �ʴ� ƽ
    public int Range;                   // ��Ÿ� (��ĵ�� ���۵Ǵ� ��� ��ġ�ε� ���)
    public float CastTime;              // �����ð�
    public int ProjectileSpeed;         // ����ü �ӵ�
    public bool CanPenetration;         // ���� ����
    //public float ProjectileSize;        // ����ü ũ�� (���� ��뿩�� Ȯ�� �� ��)

    public void Load(string[] fields)
    {
        ID = int.Parse(fields[0]);                  // Parse ID
        Name = fields[1];                           // Parse Name
        Description = fields[2];                    // Parse Description
        Enum.TryParse(fields[3], out SkillType);    // Parse SkillType
        Enum.TryParse(fields[4], out Grade);        // Parse Grade
        Damage = float.Parse(fields[5]);            // Parse Damage
        CoolTime = int.Parse(fields[6]);            // Parse CoolTime
        Price = int.Parse(fields[7]);               // Parse Price
        Radius = int.Parse(fields[8]);              // Parse Radius
        ClassName = fields[9];                      // Parse ClassName
        Second = int.Parse(fields[10]);             // Parse Second
        Tick = float.Parse(fields[11]);             // Parse Tick
        Range = int.Parse(fields[12]);              // Parse Range
        CastTime = float.Parse(fields[13]);           // Parse CastTime
        ProjectileSpeed = int.Parse(fields[14]);    // Parse Projectile Speed
        CanPenetration = bool.Parse(fields[15]);    // Parse Can Penetration
        //ProjectileSize = float.Parse(fields[16]);   // Parse Projectile Size
    }
}