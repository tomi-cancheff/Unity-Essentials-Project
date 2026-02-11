# Unity Essentials Project

Proyecto de práctica en **Unity** orientado a recorrer mecánicas esenciales de desarrollo de juegos en 3D y 2D. Está pensado como una colección de escenas cortas donde se exploran navegación, interacción, audio, programación de gameplay y una escena bonus personalizable.

## ¿Qué incluye?
- **7 escenas en Build Settings** con progresión desde menú principal hasta escena bonus:
  - `0_MainMenu_Scene`
  - `1_Playground_Navigation_Scene`
  - `2_KidsRoom_3D_Scene`
  - `3_Kitchen_Audio_Scene`
  - `4_LivingRoom_Programming_Scene`
  - `5_TopDown_2D_Scene`
  - `6_Bonus_Custom_Scene`
- Ejemplos de mecánicas comunes:
  - Movimiento de jugador en 3D y 2D.
  - Coleccionables y contador en UI.
  - Puertas/interacciones por trigger.
  - Ciclo día/noche.
  - Cambio entre escenas y navegación desde menú.

## Stack técnico
- **Unity 6** (`6000.2.6f2`).
- Render Pipeline: **URP**.
- Paquetes relevantes: Input System, Cinemachine, TextMeshPro y feature set 2D.

## Cómo abrir y ejecutar
1. Abre el proyecto desde **Unity Hub**.
2. Usa la versión de Unity indicada arriba.
3. Carga la escena `Assets/_Unity Essentials/Scenes/0_MainMenu_Scene.unity`.
4. Presiona **Play** para iniciar la navegación entre escenas.

## Controles base (según escena)
- **WASD / Flechas**: movimiento.
- **Espacio**: salto (escenas 3D con `PlayerController`).
- **Esc**: regresar al menú principal en escenas distintas al índice 0.

## Estructura principal
- `Assets/_Unity Essentials/Scenes/`: escenas del recorrido.
- `Assets/_Unity Essentials/Scripts/`: scripts de gameplay (player, coleccionables, día/noche, puertas).
- `Assets/_Unity Essentials/Source Files/Scripts/`: utilidades y scripts de apoyo (scene manager, contador UI, etc.).

---
Si es tu primera vez viendo este repositorio, la mejor forma de explorarlo es recorrer las escenas en orden y revisar los scripts asociados a cada mecánica.
