-- tsl
-- 2021-7-30
-- LayerManager.lua
-- 层级管理

-- 舞台
local layerManager = {}
--舞台
layerManager.stage = nil 
-- 场景层
layerManager.sceneLayer = nil
-- 场景面板层
layerManager.panelLayer = nil
-- 公用资源条层
layerManager.sourceLayer = nil
-- 提示层
layerManager.tipLayer = nil
-- 弹幕层
layerManager.danmuLayer = nil
-- 新手引导层
layerManager.guilderLayer = nil
-- 加载层
layerManager.netLoadLayer = nil

function layerManager:ctor()
	-- 初始化
	
end

return layerManager