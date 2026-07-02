<template>
  <div class="service-page">
    <section class="service-hero">
      <div class="service-hero-copy">
        <p class="eyebrow">Data Analytics</p>
        <h1>Turn operational data into decisions your team can actually use.</h1>
        <p>
          The goal is not more dashboards. It is cleaner information, sharper insights, and a reporting workflow that helps people act with confidence.
        </p>
      </div>

      <div class="service-hero-panel">
        <p class="panel-label">The three-step flow</p>
        <div class="hero-step-list">
          <article v-for="step in steps" :key="step.title" class="mini-step-card">
            <span>{{ step.index }}</span>
            <strong>{{ step.title }}</strong>
            <p>{{ step.summary }}</p>
          </article>
        </div>
      </div>
    </section>

    <section class="feature-grid">
      <article v-for="step in steps" :key="step.title" class="feature-card">
        <div class="feature-card-copy">
          <p class="card-label">{{ step.index }}</p>
          <h2>{{ step.title }}</h2>
          <p>{{ step.description }}</p>
          <ul>
            <li v-for="point in step.points" :key="point">{{ point }}</li>
          </ul>
        </div>
        <div class="feature-card-media">
          <img :src="step.image" :alt="step.alt" />
        </div>
      </article>
    </section>

    <section class="insight-band">
      <article v-for="stat in stats" :key="stat.title" class="stat-card">
        <p class="card-label">{{ stat.label }}</p>
        <h3>{{ stat.title }}</h3>
        <p>{{ stat.text }}</p>
      </article>
    </section>

    <section class="cta-strip">
      <div>
        <p class="eyebrow">Next step</p>
        <h2>If your data is useful only after manual effort, the system is doing too much work.</h2>
      </div>
      <RouterLink class="button button-primary" to="/Contact">Talk about your data</RouterLink>
    </section>
  </div>
</template>

<script setup>
import exploreImage from '../assets/data_analytics_explore.png'
import enrichImage from '../assets/data_analytics_enrich.png'
import presentImage from '../assets/data_analytics_present.png'

const steps = [
  {
    index: '01',
    title: 'Explore',
    summary: 'Find what is hidden in files, systems, and disconnected exports.',
    description: 'We identify where the signal is, what is missing, and what needs to be joined before analysis is trustworthy.',
    points: ['Map data sources and gaps', 'Surface operational patterns', 'Identify quick wins and risks'],
    image: exploreImage,
    alt: 'Data exploration visual',
  },
  {
    index: '02',
    title: 'Enrich',
    summary: 'Improve quality with extra context and structure.',
    description: 'Useful reporting depends on reliable inputs. We clean, normalise, and enrich data so it can be used without constant caveats.',
    points: ['Normalise inconsistent fields', 'Add supporting context', 'Prepare data for repeatable analysis'],
    image: enrichImage,
    alt: 'Data enrichment visual',
  },
  {
    index: '03',
    title: 'Present',
    summary: 'Shape the result into reporting leaders will actually read.',
    description: 'The output should be easy to understand at a glance and rich enough to support the next decision without a follow-up meeting.',
    points: ['Create clear reporting views', 'Highlight trends and exceptions', 'Make decisions easier to defend'],
    image: presentImage,
    alt: 'Data presentation visual',
  },
]

const stats = [
  { label: 'Outcome', title: 'Less guessing', text: 'Replace opinion-heavy meetings with reporting that shows what is really happening.' },
  { label: 'Outcome', title: 'More signal', text: 'Remove duplicates, noise, and dead ends so the useful information stands out.' },
  { label: 'Outcome', title: 'Better follow-through', text: 'Turn analysis into a repeatable workflow instead of a one-off project.' },
]
</script>

<style scoped>
.service-page {
  max-width: 1240px;
  margin: 0 auto;
  padding: 1.25rem 1rem 4rem;
  color: #1f1a1a;
  font-family: Inter, "Segoe UI", Arial, sans-serif;
}

.service-hero,
.cta-strip,
.insight-band {
  display: grid;
  gap: 1rem;
}

.service-hero {
  padding: 2rem 0 1.5rem;
}

.service-hero-copy,
.service-hero-panel,
.feature-card,
.stat-card,
.cta-strip {
  background: rgba(255, 255, 255, 0.88);
  border: 1px solid rgba(123, 21, 28, 0.09);
  box-shadow: 0 18px 45px rgba(31, 16, 18, 0.08);
  backdrop-filter: blur(10px);
  border-radius: 1.5rem;
}

.service-hero-copy,
.service-hero-panel,
.stat-card,
.cta-strip {
  padding: 1.5rem;
}

.service-hero h1,
.feature-card h2,
.cta-strip h2 {
  margin: 0;
  font-family: Georgia, "Times New Roman", serif;
  letter-spacing: -0.03em;
  color: #170f10;
}

.service-hero h1 {
  font-size: clamp(2.4rem, 7vw, 4.8rem);
  line-height: 0.98;
  max-width: 13ch;
}

.service-hero p,
.feature-card p,
.stat-card p,
.mini-step-card p {
  margin: 0;
  color: #514548;
  line-height: 1.7;
}

.eyebrow,
.panel-label,
.card-label {
  margin: 0 0 0.85rem;
  color: #9c1c24;
  text-transform: uppercase;
  letter-spacing: 0.18em;
  font-size: 0.74rem;
  font-weight: 800;
}

.hero-step-list,
.feature-grid,
.insight-band {
  display: grid;
  gap: 1rem;
}

.mini-step-card {
  padding: 1rem 0 0;
  border-top: 1px solid rgba(123, 21, 28, 0.12);
}

.mini-step-card:first-child {
  border-top: none;
  padding-top: 0;
}

.mini-step-card span {
  display: inline-flex;
  margin-bottom: 0.45rem;
  color: #7b151c;
  font-weight: 900;
}

.mini-step-card strong,
.stat-card h3 {
  display: block;
  margin-bottom: 0.35rem;
  color: #170f10;
  font-size: 1.08rem;
}

.feature-card {
  overflow: hidden;
}

.feature-card-copy {
  padding: 1.35rem;
}

.feature-card h2 {
  font-size: 1.6rem;
  margin-bottom: 0.6rem;
}

.feature-card ul {
  margin: 1rem 0 0;
  padding-left: 1.1rem;
  line-height: 1.7;
  color: #514548;
}

.feature-card li + li {
  margin-top: 0.35rem;
}

.feature-card-media {
  height: 15rem;
  background: #1a1112;
}

.feature-card-media img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.stat-card h3 {
  margin: 0 0 0.35rem;
}

.cta-strip {
  align-items: center;
  margin-top: 2rem;
  background: linear-gradient(135deg, rgba(248, 239, 239, 0.96), rgba(255, 255, 255, 0.92));
}

.button {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  min-height: 3rem;
  padding: 0.85rem 1.25rem;
  border-radius: 999px;
  text-decoration: none;
  font-weight: 800;
  border: none;
  cursor: pointer;
}

.button-primary {
  background: linear-gradient(135deg, #b51721 0%, #e23d33 100%);
  color: #fff;
}

@media (min-width: 900px) {
  .service-page {
    padding: 2rem 2rem 5rem;
  }

  .service-hero {
    grid-template-columns: minmax(0, 1.08fr) minmax(0, 0.92fr);
    gap: 1.25rem;
    padding-top: 3rem;
  }

  .feature-grid {
    gap: 1.25rem;
  }

  .feature-card {
    display: grid;
    grid-template-columns: minmax(0, 1fr) minmax(18rem, 0.9fr);
    align-items: stretch;
  }

  .feature-card-media {
    height: auto;
    min-height: 100%;
  }

  .insight-band {
    grid-template-columns: repeat(3, minmax(0, 1fr));
    margin-top: 0.25rem;
  }

  .cta-strip {
    grid-template-columns: minmax(0, 1fr) auto;
  }
}
</style>

