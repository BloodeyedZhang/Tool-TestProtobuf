//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: protocal_logic.proto
namespace gprotocol
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CS_Kapai")]
  public partial class CS_Kapai : global::ProtoBuf.IExtensible
  {
    public CS_Kapai() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _kapai_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"kapai_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int kapai_id
    {
      get { return _kapai_id; }
      set { _kapai_id = value; }
    }
    private long _player_id = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private int _dalei = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"dalei", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dalei
    {
      get { return _dalei; }
      set { _dalei = value; }
    }
    private int _bingzhong = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"bingzhong", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bingzhong
    {
      get { return _bingzhong; }
      set { _bingzhong = value; }
    }
    private int _pinzhi = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"pinzhi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pinzhi
    {
      get { return _pinzhi; }
      set { _pinzhi = value; }
    }
    private float _jiachengbi = default(float);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"jiachengbi", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float jiachengbi
    {
      get { return _jiachengbi; }
      set { _jiachengbi = value; }
    }
    private int _s_dengji = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"s_dengji", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int s_dengji
    {
      get { return _s_dengji; }
      set { _s_dengji = value; }
    }
    private int _jingyan = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"jingyan", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int jingyan
    {
      get { return _jingyan; }
      set { _jingyan = value; }
    }
    private int _xingji = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"xingji", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int xingji
    {
      get { return _xingji; }
      set { _xingji = value; }
    }
    private int _shengming = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"shengming", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int shengming
    {
      get { return _shengming; }
      set { _shengming = value; }
    }
    private int _gongji = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"gongji", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gongji
    {
      get { return _gongji; }
      set { _gongji = value; }
    }
    private int _zhiliao = default(int);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"zhiliao", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int zhiliao
    {
      get { return _zhiliao; }
      set { _zhiliao = value; }
    }
    private int _jingyan_shangxian = default(int);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"jingyan_shangxian", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int jingyan_shangxian
    {
      get { return _jingyan_shangxian; }
      set { _jingyan_shangxian = value; }
    }
    private float _speed = default(float);
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"speed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float speed
    {
      get { return _speed; }
      set { _speed = value; }
    }
    private float _jingzun = default(float);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"jingzun", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float jingzun
    {
      get { return _jingzun; }
      set { _jingzun = value; }
    }
    private float _fanwei = default(float);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"fanwei", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue(default(float))]
    public float fanwei
    {
      get { return _fanwei; }
      set { _fanwei = value; }
    }
    private int _jiachengzhonglei = default(int);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"jiachengzhonglei", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int jiachengzhonglei
    {
      get { return _jiachengzhonglei; }
      set { _jiachengzhonglei = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CS_KapaiList")]
  public partial class CS_KapaiList : global::ProtoBuf.IExtensible
  {
    public CS_KapaiList() {}
    
    private readonly global::System.Collections.Generic.List<CS_Kapai> _list = new global::System.Collections.Generic.List<CS_Kapai>();
    [global::ProtoBuf.ProtoMember(1, Name=@"list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CS_Kapai> list
    {
      get { return _list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CS_Kapai_New")]
  public partial class CS_Kapai_New : global::ProtoBuf.IExtensible
  {
    public CS_Kapai_New() {}
    
    private int _id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _dalei = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dalei", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dalei
    {
      get { return _dalei; }
      set { _dalei = value; }
    }
    private int _bingzhong = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bingzhong", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bingzhong
    {
      get { return _bingzhong; }
      set { _bingzhong = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SoilderTeam")]
  public partial class SoilderTeam : global::ProtoBuf.IExtensible
  {
    public SoilderTeam() {}
    
    private int _team_id = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"team_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int team_id
    {
      get { return _team_id; }
      set { _team_id = value; }
    }
    private string _soilderIds = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"soilderIds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string soilderIds
    {
      get { return _soilderIds; }
      set { _soilderIds = value; }
    }
    private long _player_id = default(long);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private int _shengmingzhi = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"shengmingzhi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int shengmingzhi
    {
      get { return _shengmingzhi; }
      set { _shengmingzhi = value; }
    }
    private int _gongjizhi = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"gongjizhi", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int gongjizhi
    {
      get { return _gongjizhi; }
      set { _gongjizhi = value; }
    }
    private string _player_name = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string player_name
    {
      get { return _player_name; }
      set { _player_name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResPlayerTeamMessage")]
  public partial class ResPlayerTeamMessage : global::ProtoBuf.IExtensible
  {
    public ResPlayerTeamMessage() {}
    
    private readonly global::System.Collections.Generic.List<SoilderTeam> _teamList = new global::System.Collections.Generic.List<SoilderTeam>();
    [global::ProtoBuf.ProtoMember(1, Name=@"teamList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SoilderTeam> teamList
    {
      get { return _teamList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResRankTeamMessage")]
  public partial class ResRankTeamMessage : global::ProtoBuf.IExtensible
  {
    public ResRankTeamMessage() {}
    
    private readonly global::System.Collections.Generic.List<SoilderTeam> _teamList = new global::System.Collections.Generic.List<SoilderTeam>();
    [global::ProtoBuf.ProtoMember(14, Name=@"teamList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SoilderTeam> teamList
    {
      get { return _teamList; }
    }
  
    private readonly global::System.Collections.Generic.List<CS_Kapai> _kapais = new global::System.Collections.Generic.List<CS_Kapai>();
    [global::ProtoBuf.ProtoMember(15, Name=@"kapais", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CS_Kapai> kapais
    {
      get { return _kapais; }
    }
  
    private readonly global::System.Collections.Generic.List<CS_Kapai> _kapais_enemy = new global::System.Collections.Generic.List<CS_Kapai>();
    [global::ProtoBuf.ProtoMember(16, Name=@"kapais_enemy", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CS_Kapai> kapais_enemy
    {
      get { return _kapais_enemy; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReqRankBattleEndMessage")]
  public partial class ReqRankBattleEndMessage : global::ProtoBuf.IExtensible
  {
    public ReqRankBattleEndMessage() {}
    
    private int _code = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int code
    {
      get { return _code; }
      set { _code = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResRankBattleEndMessage")]
  public partial class ResRankBattleEndMessage : global::ProtoBuf.IExtensible
  {
    public ResRankBattleEndMessage() {}
    
    private int _code = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int code
    {
      get { return _code; }
      set { _code = value; }
    }
    private int _money1 = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"money1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int money1
    {
      get { return _money1; }
      set { _money1 = value; }
    }
    private int _bonus_points = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"bonus_points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bonus_points
    {
      get { return _bonus_points; }
      set { _bonus_points = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}