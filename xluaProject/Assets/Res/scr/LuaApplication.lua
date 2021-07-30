-- tsl
-- 2021-7-16
-- LuaApplication.lua
-- lua端程序入口
print("---------lua端程序入口")

-- 全局变量
g = g or {__loaded = {}}

-- 重写require  方法
ori_require = ori_require or require
require = (function (oriRequire)
	return  function (name)
				if not g.__loaded[name] then -- 标记被加载的文件
					g.__loaded[name] = 0
				end
			return oriRequire(name)
			end
end)(ori_require)

------------------------------------------
-- CS
local LuaApplication = {}
--
function LuaApplication.init()
	require("Initer")
end
-- 
function LuaApplication.start()
	-- body
end

function LuaApplication.update()
	
end

function LuaApplication.quit()
	
end

function LuaApplication.destroy()
	-- body
end
return LuaApplication
