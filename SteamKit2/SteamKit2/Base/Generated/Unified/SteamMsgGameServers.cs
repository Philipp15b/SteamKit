//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: steammessages_gameservers.steamclient.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameServers_GetServerList_Request")]
  public partial class CGameServers_GetServerList_Request : global::ProtoBuf.IExtensible
  {
    public CGameServers_GetServerList_Request() {}
    

    private string _filter;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"filter", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string filter
    {
      get { return _filter?? ""; }
      set { _filter = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool filterSpecified
    {
      get { return _filter != null; }
      set { if (value == (_filter== null)) _filter = value ? this.filter : (string)null; }
    }
    private bool ShouldSerializefilter() { return filterSpecified; }
    private void Resetfilter() { filterSpecified = false; }
    

    private uint? _limit;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"limit", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint limit
    {
      get { return _limit?? (uint)100; }
      set { _limit = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool limitSpecified
    {
      get { return _limit != null; }
      set { if (value == (_limit== null)) _limit = value ? this.limit : (uint?)null; }
    }
    private bool ShouldSerializelimit() { return limitSpecified; }
    private void Resetlimit() { limitSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameServers_GetServerList_Response")]
  public partial class CGameServers_GetServerList_Response : global::ProtoBuf.IExtensible
  {
    public CGameServers_GetServerList_Response() {}
    
    private readonly global::System.Collections.Generic.List<CGameServers_GetServerList_Response.Server> _servers = new global::System.Collections.Generic.List<CGameServers_GetServerList_Response.Server>();
    [global::ProtoBuf.ProtoMember(1, Name=@"servers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CGameServers_GetServerList_Response.Server> servers
    {
      get { return _servers; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Server")]
  public partial class Server : global::ProtoBuf.IExtensible
  {
    public Server() {}
    

    private string _addr;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"addr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string addr
    {
      get { return _addr?? ""; }
      set { _addr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool addrSpecified
    {
      get { return _addr != null; }
      set { if (value == (_addr== null)) _addr = value ? this.addr : (string)null; }
    }
    private bool ShouldSerializeaddr() { return addrSpecified; }
    private void Resetaddr() { addrSpecified = false; }
    

    private uint? _gameport;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"gameport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint gameport
    {
      get { return _gameport?? default(uint); }
      set { _gameport = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool gameportSpecified
    {
      get { return _gameport != null; }
      set { if (value == (_gameport== null)) _gameport = value ? this.gameport : (uint?)null; }
    }
    private bool ShouldSerializegameport() { return gameportSpecified; }
    private void Resetgameport() { gameportSpecified = false; }
    

    private uint? _specport;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"specport", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint specport
    {
      get { return _specport?? default(uint); }
      set { _specport = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool specportSpecified
    {
      get { return _specport != null; }
      set { if (value == (_specport== null)) _specport = value ? this.specport : (uint?)null; }
    }
    private bool ShouldSerializespecport() { return specportSpecified; }
    private void Resetspecport() { specportSpecified = false; }
    

    private ulong? _steamid;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong steamid
    {
      get { return _steamid?? default(ulong); }
      set { _steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool steamidSpecified
    {
      get { return _steamid != null; }
      set { if (value == (_steamid== null)) _steamid = value ? this.steamid : (ulong?)null; }
    }
    private bool ShouldSerializesteamid() { return steamidSpecified; }
    private void Resetsteamid() { steamidSpecified = false; }
    

    private string _name;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name?? ""; }
      set { _name = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool nameSpecified
    {
      get { return _name != null; }
      set { if (value == (_name== null)) _name = value ? this.name : (string)null; }
    }
    private bool ShouldSerializename() { return nameSpecified; }
    private void Resetname() { nameSpecified = false; }
    

    private uint? _appid;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint appid
    {
      get { return _appid?? default(uint); }
      set { _appid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool appidSpecified
    {
      get { return _appid != null; }
      set { if (value == (_appid== null)) _appid = value ? this.appid : (uint?)null; }
    }
    private bool ShouldSerializeappid() { return appidSpecified; }
    private void Resetappid() { appidSpecified = false; }
    

    private string _gamedir;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"gamedir", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gamedir
    {
      get { return _gamedir?? ""; }
      set { _gamedir = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool gamedirSpecified
    {
      get { return _gamedir != null; }
      set { if (value == (_gamedir== null)) _gamedir = value ? this.gamedir : (string)null; }
    }
    private bool ShouldSerializegamedir() { return gamedirSpecified; }
    private void Resetgamedir() { gamedirSpecified = false; }
    

    private string _version;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string version
    {
      get { return _version?? ""; }
      set { _version = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool versionSpecified
    {
      get { return _version != null; }
      set { if (value == (_version== null)) _version = value ? this.version : (string)null; }
    }
    private bool ShouldSerializeversion() { return versionSpecified; }
    private void Resetversion() { versionSpecified = false; }
    

    private string _product;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"product", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string product
    {
      get { return _product?? ""; }
      set { _product = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool productSpecified
    {
      get { return _product != null; }
      set { if (value == (_product== null)) _product = value ? this.product : (string)null; }
    }
    private bool ShouldSerializeproduct() { return productSpecified; }
    private void Resetproduct() { productSpecified = false; }
    

    private int? _region;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"region", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int region
    {
      get { return _region?? default(int); }
      set { _region = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool regionSpecified
    {
      get { return _region != null; }
      set { if (value == (_region== null)) _region = value ? this.region : (int?)null; }
    }
    private bool ShouldSerializeregion() { return regionSpecified; }
    private void Resetregion() { regionSpecified = false; }
    

    private int? _players;
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"players", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int players
    {
      get { return _players?? default(int); }
      set { _players = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool playersSpecified
    {
      get { return _players != null; }
      set { if (value == (_players== null)) _players = value ? this.players : (int?)null; }
    }
    private bool ShouldSerializeplayers() { return playersSpecified; }
    private void Resetplayers() { playersSpecified = false; }
    

    private int? _max_players;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"max_players", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int max_players
    {
      get { return _max_players?? default(int); }
      set { _max_players = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool max_playersSpecified
    {
      get { return _max_players != null; }
      set { if (value == (_max_players== null)) _max_players = value ? this.max_players : (int?)null; }
    }
    private bool ShouldSerializemax_players() { return max_playersSpecified; }
    private void Resetmax_players() { max_playersSpecified = false; }
    

    private int? _bots;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"bots", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int bots
    {
      get { return _bots?? default(int); }
      set { _bots = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool botsSpecified
    {
      get { return _bots != null; }
      set { if (value == (_bots== null)) _bots = value ? this.bots : (int?)null; }
    }
    private bool ShouldSerializebots() { return botsSpecified; }
    private void Resetbots() { botsSpecified = false; }
    

    private string _map;
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"map", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string map
    {
      get { return _map?? ""; }
      set { _map = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool mapSpecified
    {
      get { return _map != null; }
      set { if (value == (_map== null)) _map = value ? this.map : (string)null; }
    }
    private bool ShouldSerializemap() { return mapSpecified; }
    private void Resetmap() { mapSpecified = false; }
    

    private bool? _secure;
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"secure", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool secure
    {
      get { return _secure?? default(bool); }
      set { _secure = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool secureSpecified
    {
      get { return _secure != null; }
      set { if (value == (_secure== null)) _secure = value ? this.secure : (bool?)null; }
    }
    private bool ShouldSerializesecure() { return secureSpecified; }
    private void Resetsecure() { secureSpecified = false; }
    

    private bool? _dedicated;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"dedicated", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool dedicated
    {
      get { return _dedicated?? default(bool); }
      set { _dedicated = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool dedicatedSpecified
    {
      get { return _dedicated != null; }
      set { if (value == (_dedicated== null)) _dedicated = value ? this.dedicated : (bool?)null; }
    }
    private bool ShouldSerializededicated() { return dedicatedSpecified; }
    private void Resetdedicated() { dedicatedSpecified = false; }
    

    private string _os;
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"os", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string os
    {
      get { return _os?? ""; }
      set { _os = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool osSpecified
    {
      get { return _os != null; }
      set { if (value == (_os== null)) _os = value ? this.os : (string)null; }
    }
    private bool ShouldSerializeos() { return osSpecified; }
    private void Resetos() { osSpecified = false; }
    

    private string _gametype;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"gametype", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string gametype
    {
      get { return _gametype?? ""; }
      set { _gametype = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool gametypeSpecified
    {
      get { return _gametype != null; }
      set { if (value == (_gametype== null)) _gametype = value ? this.gametype : (string)null; }
    }
    private bool ShouldSerializegametype() { return gametypeSpecified; }
    private void Resetgametype() { gametypeSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameServers_GetServerSteamIDsByIP_Request")]
  public partial class CGameServers_GetServerSteamIDsByIP_Request : global::ProtoBuf.IExtensible
  {
    public CGameServers_GetServerSteamIDsByIP_Request() {}
    
    private readonly global::System.Collections.Generic.List<string> _server_ips = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"server_ips", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> server_ips
    {
      get { return _server_ips; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameServers_IPsWithSteamIDs_Response")]
  public partial class CGameServers_IPsWithSteamIDs_Response : global::ProtoBuf.IExtensible
  {
    public CGameServers_IPsWithSteamIDs_Response() {}
    
    private readonly global::System.Collections.Generic.List<CGameServers_IPsWithSteamIDs_Response.Server> _servers = new global::System.Collections.Generic.List<CGameServers_IPsWithSteamIDs_Response.Server>();
    [global::ProtoBuf.ProtoMember(1, Name=@"servers", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<CGameServers_IPsWithSteamIDs_Response.Server> servers
    {
      get { return _servers; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Server")]
  public partial class Server : global::ProtoBuf.IExtensible
  {
    public Server() {}
    

    private string _addr;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"addr", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string addr
    {
      get { return _addr?? ""; }
      set { _addr = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool addrSpecified
    {
      get { return _addr != null; }
      set { if (value == (_addr== null)) _addr = value ? this.addr : (string)null; }
    }
    private bool ShouldSerializeaddr() { return addrSpecified; }
    private void Resetaddr() { addrSpecified = false; }
    

    private ulong? _steamid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public ulong steamid
    {
      get { return _steamid?? default(ulong); }
      set { _steamid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool steamidSpecified
    {
      get { return _steamid != null; }
      set { if (value == (_steamid== null)) _steamid = value ? this.steamid : (ulong?)null; }
    }
    private bool ShouldSerializesteamid() { return steamidSpecified; }
    private void Resetsteamid() { steamidSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGameServers_GetServerIPsBySteamID_Request")]
  public partial class CGameServers_GetServerIPsBySteamID_Request : global::ProtoBuf.IExtensible
  {
    public CGameServers_GetServerIPsBySteamID_Request() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _server_steamids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"server_steamids", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public global::System.Collections.Generic.List<ulong> server_steamids
    {
      get { return _server_steamids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IGameServers
    {
      CGameServers_GetServerList_Response GetServerList(CGameServers_GetServerList_Request request);
    CGameServers_IPsWithSteamIDs_Response GetServerSteamIDsByIP(CGameServers_GetServerSteamIDsByIP_Request request);
    CGameServers_IPsWithSteamIDs_Response GetServerIPsBySteamID(CGameServers_GetServerIPsBySteamID_Request request);
    
    }
    
    
}
#pragma warning restore 1591
