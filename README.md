# Bubble-Burst-2d
## 2d Top Down bubble shooter game made with Unity3d
### //@author Onyekwere Kelechi Mark(khelechy)
### //Github: www.github.com/khelechy



# Opensource 2d Unity Game Development



## @Project: BURST [2d topDown Bubble shooter]
### Target Platform: Mobile Devices, Pcs and Mac, Steam.

_*Ground written Scripts in C# , commented, Readable and Understandable to beginners*_


*Unity Installed Componenets
PostProcessing, TileMaps, MkGlow Effects*

![Editor](https://github.com/Khelechy/Bubble-Burst-2d/blob/master/editor.png)

# Documentation
Scripts
*. Bullet.cs
*. CameraController.cs
*. CameraShake.cs
*. EnemyAi.cs
*. EnemyBullet.cs
*. FirePower.cs
*. PlayerController.cs

### Game Effects
LinePrefabs with Glow effects
CameraShake on shooting
Shooting Effects and DeathEffects(Particle Effects)


# SCRIPTS DOCUMENTATION


## *. Bullet.cs

//This contains Bullet attributes for the player Shooting
Bullet speed, damages, effects (Easily Tweakable in Inspector)

## *. CameraController.cs

//Camera Movement script following player

## *. CameraShake.cs

//Camera Shake effect 
shake Values (Magnitude, timing ) easily editable in the Inspector

## *. EnemyAi.cs 

//Enemy Movement and Shooting
Controls The movemnt of the enemy in terms of Following the player and Retreating
shooting, shooting speed variables(shot intervals, Bullets Prefabs, FirePoints and Target(player))

## *. EnemyBullet.cs

//Enemy bullets attributes
Enemy Bullet pursuing Player(Movement)
Bullet collison with player and Environment(TileMap)

## *. FirePower.cs

//Player Gun Activity, Shoot Input and Shoot effect

## *. PlayerController.cs

//Player Movement
Player Movement variables(Speed, Jump, ExtraJumps)
Player Groundness Check(groundCheck(gameObject beeath Player), whatisGround(LayerMask), checkRadius(radius of ground check))
Player Flipping based on Direction




