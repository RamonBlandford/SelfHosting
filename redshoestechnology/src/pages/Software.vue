<template>
  <div class="service-page">
    <section class="service-hero">
      <div class="service-hero-copy">
        <p class="eyebrow">Software Engineering</p>
        <h1>Make software feel lighter, clearer, and more dependable.</h1>
        <p>
          Whether you need to stabilise a platform, modernise an ageing system, or build something new, the work should feel controlled rather than chaotic.
        </p>
      </div>

      <div class="service-hero-panel">
        <p class="panel-label">Our approach</p>
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
        <h2>If software is slowing the business, the fix should reduce complexity rather than add more.</h2>
      </div>
      <RouterLink class="button button-primary" to="/Contact">Talk about your software</RouterLink>
    </section>
  </div>
</template>

<script setup>
import evaluateImage from '../assets/software_evaluate.png'
import enhanceImage from '../assets/software_enhance.png'
import supportImage from '../assets/software_monitoring.png'

const steps = [
  {
    index: '01',
    title: 'Evaluate',
    summary: 'Identify performance gaps, risk, and wasted effort.',
    description: 'We review the system with enough depth to understand what is slowing the team down and what should be changed first.',
    points: ['Assess bottlenecks and failure points', 'Identify technical debt worth paying down', 'Prioritise work by business impact'],
    image: evaluateImage,
    alt: 'Software evaluation visual',
  },
  {
    index: '02',
    title: 'Enhance',
    summary: 'Improve existing platforms or build a focused replacement.',
    description: 'The goal is to shape software around how the business actually works, not around a generic template.',
    points: ['Modernise the weakest parts first', 'Build for maintainability', 'Keep the solution aligned to operations'],
    image: enhanceImage,
    alt: 'Software enhancement visual',
  },
  {
    index: '03',
    title: 'Support',
    summary: 'Keep the system stable after delivery.',
    description: 'Ongoing support makes sure the software keeps doing its job after launch, when real users start putting it to work.',
    points: ['Support the release and handover', 'Monitor and resolve issues early', 'Keep the platform dependable over time'],
    image: supportImage,
    alt: 'Software support visual',
  },
]

const stats = [
  { label: 'Focus', title: 'Stability first', text: 'Good software should be dependable before it is clever.' },
  { label: 'Focus', title: 'Less friction', text: 'The best improvements are often the ones users barely notice because the workflow is smoother.' },
  { label: 'Focus', title: 'Practical change', text: 'The solution should fit the team you have now, not an imaginary future operating model.' },
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

