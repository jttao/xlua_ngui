print("hello hotfix1")

xlua.hotfix(CS.HotfixDome, 'HideUI', function(self) 
    print("Hide on lua")
    self.mSprite.gameObject:SetActive (false)	
end)