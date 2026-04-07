---
description: "Use when editing Hugo posts, pages, front matter, layouts, shortcodes, taxonomy content, or static site structure under src/."
name: "Hugo Content and Layout Guidance"
applyTo: "src/**/*.md, src/**/*.html, src/**/*.yaml, src/**/*.toml"
---
# Hugo Content and Layout Guidance

- Preserve existing front matter keys and date/category/tag conventions used in neighboring content files.
- Keep slug, title, and path conventions consistent with existing content under src/content/.
- Prefer reusable partials and layouts over copying markup across multiple templates.
- Do not edit generated output under src/public/ unless explicitly asked.
- When changing layout behavior, check impact on list pages, taxonomy pages, and robots/sitemap output.
