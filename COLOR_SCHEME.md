# Barevné schéma – MichalSvoboda.Web

Barevné schéma je definováno pomocí CSS custom properties (proměnných) v souboru
`MichalSvoboda.Web/wwwroot/css/site.css`.

---

## Globální proměnné (`:root` – světlý režim, výchozí)

| Proměnná | Hodnota | Popis |
|---|---|---|
| `--bg` | `#f6f8fb` | Hlavní barva pozadí stránky |
| `--bg2` | `#ffffff` | Sekundární pozadí (karty, panely) |
| `--text` | `#0b1220` | Barva základního textu |
| `--muted` | `#516074` | Tlumená/doplňková barva textu |
| `--line` | `#e5eaf2` | Barva oddělovacích čar a ohraničení |
| `--card` | `#ffffff` | Pozadí karet |
| `--shadow` | `0 16px 40px rgba(15,23,42,.10)` | Stín karet |
| `--r` | `16px` | Výchozí poloměr zaoblení rohů |
| `--max` | `980px` | Maximální šířka obsahu (container) |
| `--bg-grad` | radial-gradient (modrá + fialová aura) | Dekorativní přechodový gradient pozadí |
| `--topbar-bg` | `rgba(246,248,251,.72)` | Poloprůhledné pozadí horního navigačního pruhu |
| `--glass-1` | `rgba(15,23,42,.04)` | Velmi jemná skleněná vrstva |
| `--glass-2` | `rgba(15,23,42,.07)` | Střední skleněná vrstva |
| `--glass-3` | `rgba(15,23,42,.03)` | Nejjemnější skleněná vrstva |
| `--accent1` | `#3b82f6` | Primární akcentová barva (modrá) |
| `--accent2` | `#8b5cf6` | Sekundární akcentová barva (fialová) |
| `--aura1` | `rgba(59,130,246,.12)` | Průhledná modrá aura (pro gradient pozadí) |
| `--aura2` | `rgba(139,92,246,.10)` | Průhledná fialová aura (pro gradient pozadí) |

---

## Živá varianta akcentu (`:root[data-accent="vivid"]`)

Alternativní sada akcentových barev, přepínatelná atributem `data-accent="vivid"` na elementu `<html>`.

| Proměnná | Hodnota | Popis |
|---|---|---|
| `--accent1` | `#22c55e` | Primární akcent – zelená |
| `--accent2` | `#06b6d4` | Sekundární akcent – azurová (cyan) |
| `--aura1` | `rgba(34,197,94,.16)` | Průhledná zelená aura |
| `--aura2` | `rgba(6,182,212,.14)` | Průhledná azurová aura |

---

## Tmavý režim (`html[data-theme="dark"]`)

Přepíná se nastavením atributu `data-theme="dark"` na elementu `<html>` (tlačítko 🌙/☀️ v navigaci).

| Proměnná | Hodnota | Popis |
|---|---|---|
| `--bg` | `#0b0f14` | Velmi tmavé pozadí stránky |
| `--bg2` | `#0f1620` | Tmavé sekundární pozadí |
| `--text` | `#e7edf7` | Světlý text |
| `--muted` | `#a7b4c6` | Tlumený šedomodrý text |
| `--line` | `#1b2735` | Tmavé ohraničení |
| `--card` | `#0f1620` | Tmavé pozadí karet |
| `--shadow` | `0 16px 40px rgba(0,0,0,.35)` | Silnější stín |
| `--bg-grad` | radial-gradient (jasnější modrá + fialová aura) | Výraznější dekorativní gradient |
| `--topbar-bg` | `rgba(11,15,20,.70)` | Poloprůhledné tmavé pozadí navigace |

---

## Přechody a animace

Následující elementy mají plynulý přechod (`.18s ease`) při změně tématu:
`body`, `.topbar`, `.card`, `.work`, `.btn`, `.nav-pill`, `.brand`
– pro vlastnosti: `background-color`, `color`, `border-color`.

---

## Sekce a stránky – specifické barvy

### Trip (Cesta / Cestování)
- `.trip-card` – světle modrý přechod: `rgba(233,244,255,.95) → rgba(255,255,255,.9)`
- `.journey-hero` – světlý přechod: modrá `rgba(200,230,255,.45)` → béžová `rgba(255,248,239,.72)`
- `.trip-stop` – béžovo-krémový styl: `rgba(255,255,255,.94) → rgba(246,239,229,.9)`, ohraničení `rgba(123,91,61,.16)`
- `.journey-label` – barva textu `#7b5b3d` (tmavá hnědá)
  - *Dark mode:* `.journey-hero` → tmavě modré pozadí `#0f1620`, `.trip-stop` → `#161e2c → #0f1620`

### Projects (Projekty)
- `.projects-card` – světle modrý přechod: `rgba(240,245,255,.95) → rgba(255,255,255,.9)`
- `.projects-hero` – tmavé pozadí `rgba(11,18,32,.95) → rgba(28,39,61,.96)`, barva textu `#edf3ff`, s modrou aurou
- `.spotlight` – bílý panel `rgba(245,248,255,.98) → rgba(255,255,255,.98)`
  - *Dark mode:* `.projects-hero` → `#121a2e → #0a1020`, `.spotlight` → `#151f30 → #0f1825`

### Family (Rodina)
- `.family-card` – teplý přechod: `rgba(255,241,237,.95) → rgba(255,255,255,.92)`
- `.family-hero` – teplá aura: oranžová `rgba(255,190,160,.28)` + žlutá `rgba(255,220,150,.24)`
- Jednotliví členové:
  - `.family-member.ester` – teplá růžová: `rgba(255,243,238,.98) → rgba(255,255,255,.95)`
  - `.family-member.adam` – chladná modrá: `rgba(238,246,255,.98) → rgba(255,255,255,.95)`
  - `.family-member.ema` – jemná fialová: `rgba(248,241,255,.98) → rgba(255,255,255,.95)`
  - *Dark mode:* Ester `#1c1420 → #130f18`, Adam `#101b2c → #0c1522`, Ema `#141428 → #0e0e1e`

---

## Typografie

| Vlastnost | Hodnota |
|---|---|
| Základní font | `Inter, system-ui, sans-serif` |
| Font nadpisů (h1–h3) | `"IBM Plex Sans", Inter, sans-serif` |
| Letter-spacing nadpisů | `-0.02em` |
| Velikost `.lead` | `18px` |
| Velikost `.small` / `.cardmeta` | `13px` |

---

## Souhrn barevné palety

```
Světlá varianta:
  Pozadí:    #f6f8fb / #ffffff
  Text:      #0b1220
  Tlumený:   #516074
  Linky:     #e5eaf2
  Akcent A:  #3b82f6 (modrá)
  Akcent B:  #8b5cf6 (fialová)

Živá varianta:
  Akcent A:  #22c55e (zelená)
  Akcent B:  #06b6d4 (cyan)

Tmavá varianta:
  Pozadí:    #0b0f14 / #0f1620
  Text:      #e7edf7
  Tlumený:   #a7b4c6
  Linky:     #1b2735
```
