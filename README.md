# Climber

这是UE4引擎的学习项目，引擎版本4.25.0

角色爬墙示例

技术说明：
1.使用UnLua作为脚本插件
2.ClimberCharacter_C是玩家操作的角色，通过Collision与LineTrace检查墙壁，在当前版本中，所有WorldStatic类型的物体都可以攀爬
3.通过HitResult的法线，可以算出墙壁的朝向，使得角色可以沿着圆弧墙壁攀爬
4.ClimberAnimInstance_C是动画控制，其中攀爬动画是一个BlendSpace，通过BSClimbControl控制攀爬动作。然而UE4自带的攀爬动作中竟然带了位移，为了使得逻辑位置与动画位置一致，在动画中不得不反算一次偏移，调整骨骼点

待优化：
1.角色手掌与脚掌可以使用IK，让角色到达顶部时，能真正抓住墙壁边缘
2.沿圆弧墙壁攀爬时，在更新过程中，角色偶尔会与墙壁发生物理碰撞，导致抖动
3.动画在切换时并不连贯，没有办法，UE4自带的资源缺少一些过渡动作（其实官方例子并不是做这个功能的，只是强行拿来用），已经尽可能在逻辑上让它们连贯了