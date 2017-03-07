local luaBehaviour = require('../luaBehaviour')

local luaTest1 = {}

setmetatable(luaTest1, luaBehaviour) 

luaTest1.__index = luaTest1

function luaTest1:new(mono)
    local self = luaBehaviour:new(mono) 
    setmetatable(self, luaTest1) 
    return self  
end 

function luaTest1:Start ()  
    
    print("lua Start luaTest2"..self.Mono.gameObject.name) 
    local hfdome = self.Mono.gameObject:AddComponent(typeof(CS.HotfixDome))    
    
    hfdome:HideUI()

    local obj = CS.UnityEngine.GameObject("label")
    obj.transform.parent = self.Mono.transform:FindChild ("Camera")
    local label = obj:AddComponent(typeof(CS.UILabel))
    label.text = "Hello xLua" 
    label.transform.localPosition = CS.UnityEngine.Vector3(0,50,0)
    label.bitmapFont = CS.UnityEngine.Resources.Load ("Atlases/SciFi/SciFi Font - Normal",typeof(CS.UIFont)) 
    
    local function onclick1()  
        local panel = CS.UnityEngine.GameObject.Instantiate(CS.UnityEngine.Resources.Load ("Panel1")) --, typeof(CS.UnityEngine.GameObject)
        panel.name = "Panel1"
        panel.transform.parent = self.Mono.transform
        panel.transform.localScale = CS.UnityEngine.Vector3.one 
        CS.LuaBehaviour.AddComponent (panel, "luaTest2");   
    end 
    
    local button1 = self.Mono.transform:FindChild ("Camera/Button0"):GetComponent(typeof(CS.UIButton)) 
    button1.onClick:Add (CS.EventDelegate (onclick1)); 
    button1.transform:FindChild("Label"):GetComponent(typeof(CS.UILabel)).text = "Resources"
    
    local function onclick2()  
        local path = CS.Util.WWWStreamingAssets.."ui/panel2.assetbundle"  
        self.Mono:StartWWW(path,function(ab)
            print("lua call laod www ok")  
            local panel = CS.UnityEngine.GameObject.Instantiate( ab:LoadAsset("Panel2") )
            panel.name = "panel2"
            panel.transform.parent = self.Mono.transform
            panel.transform.localScale = CS.UnityEngine.Vector3.one 
            CS.LuaBehaviour.AddComponent (panel, "luaTest3");   
        end) 
    end 
    
    local button2 = self.Mono.transform:FindChild ("Camera/Button1"):GetComponent(typeof(CS.UIButton)) 
    button2.onClick:Add (CS.EventDelegate (onclick2)); 
    button2.transform:FindChild("Label"):GetComponent(typeof(CS.UILabel)).text = "WWW"
    
    CS.LuaBehaviour.AddComponent (self.Mono.gameObject, "luaTest4");

end 

function luaTest1:A()
    print("luaTest1 -> A()")
end

lua_packages['luaTest1'] = luaTest1

return luaTest1