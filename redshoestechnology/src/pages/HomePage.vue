<template>
  <div class="home-page">
    <section class="hero-section">
      <div class="hero-copy">
        <p class="eyebrow">Red Shoes Technology</p>
        <h1>Modern software engineering for teams that want clarity, reliability, and momentum.</h1>
        <p class="hero-lede">
          We help organisations modernise legacy systems, connect disconnected tools, and turn operational data into decisions they can trust.
        </p>

        <div class="hero-actions">
          <RouterLink class="button button-primary" to="/Contact">Book a consultation</RouterLink>
          <RouterLink class="button button-secondary" to="/CaseStudies">View case studies</RouterLink>
        </div>

        <div class="proof-strip" aria-label="Key proof points">
          <article v-for="point in proofPoints" :key="point.title" class="proof-card">
            <p class="proof-label">{{ point.label }}</p>
            <h2>{{ point.title }}</h2>
            <p>{{ point.text }}</p>
          </article>
        </div>
      </div>

      <div class="hero-visual" aria-hidden="true">
        <div class="hero-image-card hero-image-card-large">
          <img :src="heroImage" alt="" />
        </div>
        <div class="hero-image-card hero-image-card-small hero-image-card-top">
          <img :src="deploymentImage" alt="" />
          <div>
            <span>Deployment</span>
            <strong>Ship with less friction</strong>
          </div>
        </div>
        <div class="hero-image-card hero-image-card-small hero-image-card-bottom">
          <img :src="analyticsImage" alt="" />
          <div>
            <span>Insights</span>
            <strong>Make the data usable</strong>
          </div>
        </div>
      </div>
    </section>

    <section class="content-section">
      <div class="section-heading">
        <p class="eyebrow">Services</p>
        <h2>Three practical ways we help clients move faster.</h2>
        <p>
          The work is usually not about more technology. It is about making the right systems easier to use, easier to trust, and easier to scale.
        </p>
      </div>

      <div class="services-grid">
        <article v-for="service in services" :key="service.title" class="service-card">
          <p class="service-index">{{ service.index }}</p>
          <h3>{{ service.title }}</h3>
          <p>{{ service.text }}</p>
          <ul>
            <li v-for="item in service.points" :key="item">{{ item }}</li>
          </ul>
        </article>
      </div>
    </section>

    <section class="content-section featured-section">
      <div class="section-heading section-heading-split">
        <div>
          <p class="eyebrow">Proof</p>
          <h2>Selected work that shows the pattern behind the promise.</h2>
        </div>
        <p>
          These examples highlight the kind of outcomes Red Shoes Technology is built for: cleaner workflows, better reporting, and systems that can keep up with the business.
        </p>
      </div>

      <div class="case-grid">
        <article v-for="caseStudy in caseStudies" :key="caseStudy.title" class="case-card">
          <div class="case-card-media">
            <img :src="caseStudy.image" :alt="caseStudy.alt" />
          </div>
          <div class="case-card-body">
            <p class="case-tag">{{ caseStudy.tag }}</p>
            <h3>{{ caseStudy.title }}</h3>
            <p>{{ caseStudy.text }}</p>
            <RouterLink class="text-link" to="/CaseStudies">Read the case studies</RouterLink>
          </div>
        </article>
      </div>
    </section>

    <section class="content-section split-section">
      <div class="quote-panel">
        <p class="eyebrow">Why work with us</p>
        <h2>Engineering with a calm, direct, business-focused style.</h2>
        <p>
          Clients work with Red Shoes Technology when they need technical depth without the usual noise. The approach is direct: understand the problem, reduce risk, and build something the team can actually maintain.
        </p>
      </div>

      <div class="reason-list">
        <article v-for="reason in reasons" :key="reason.title" class="reason-card">
          <p class="reason-step">{{ reason.step }}</p>
          <h3>{{ reason.title }}</h3>
          <p>{{ reason.text }}</p>
        </article>
      </div>
    </section>

    <section class="cta-section">
      <div>
        <p class="eyebrow">Next step</p>
        <h2>Bring the systems, workflows, or data problems you want solved.</h2>
        <p>
          If you want a homepage that feels more premium, the underlying offer should feel that way too. This version makes the value proposition easier to scan and easier to trust.
        </p>
      </div>
      <RouterLink class="button button-primary cta-button" to="/Contact">Book a free consultation</RouterLink>
    </section>
  </div>
</template>

<script setup>
import heroImage from '../assets/code_design.webp'
import deploymentImage from '../assets/software_deploy.webp'
import analyticsImage from '../assets/data_analytics_present.png'
import clinicImage from '../assets/clinic.webp'
import callCentreImage from '../assets/call_centre.webp'
import burndownImage from '../assets/burndown_monthly.png'

const proofPoints = [
  {
    label: 'Direct engagement',
    title: 'Founder-led delivery',
    text: 'You are working with people who can make decisions and keep momentum moving.',
  },
  {
    label: 'Delivery focus',
    title: 'From strategy to implementation',
    text: 'The work stays connected to outcomes, not just diagrams or requirements.',
  },
  {
    label: 'Breadth of experience',
    title: 'Government, healthcare, and operational systems',
    text: 'The case studies show a pattern of practical work across demanding environments.',
  },
]

const services = [
  {
    index: '01',
    title: 'Modernise legacy systems',
    text: 'Replace brittle manual processes and outdated tools with software that is easier to support and extend.',
    points: [
      'Reduce operational friction',
      'Replace hidden workarounds',
      'Keep business continuity front and centre',
    ],
  },
  {
    index: '02',
    title: 'Turn data into decisions',
    text: 'Expose the numbers that matter and shape them into reporting that leaders can use without translation.',
    points: [
      'Clear dashboards and reporting',
      'Better visibility into workflows',
      'Useful information, not noise',
    ],
  },
  {
    index: '03',
    title: 'Integrate what you already own',
    text: 'Connect systems so your team spends less time re-entering data and more time moving work forward.',
    points: [
      'Cleaner hand-offs between systems',
      'Less duplicate data entry',
      'More resilient day-to-day operations',
    ],
  },
]

const caseStudies = [
  {
    tag: 'Government data analytics',
    title: 'Making structured reporting out of fragmented data',
    text: 'A public-sector client needed data cleaned, connected, and presented in a way that made analysis much easier.',
    image: burndownImage,
    alt: 'Monthly data visualisation and analytics chart',
  },
  {
    tag: 'Healthcare workflow',
    title: 'Reducing manual work for a medical clinic',
    text: 'A clinic workflow was improved with automation and reporting that helped the team focus on patient care.',
    image: clinicImage,
    alt: 'Medical clinic workflow visual',
  },
  {
    tag: 'Operational systems',
    title: 'Stabilising a call centre environment',
    text: 'An ageing communications stack was modernised to improve reliability, usability, and continuity.',
    image: callCentreImage,
    alt: 'Call centre operations visual',
  },
]

const reasons = [
  {
    step: 'A',
    title: 'Less jargon, more clarity',
    text: 'The language stays simple enough for non-technical stakeholders while still being credible to technical teams.',
  },
  {
    step: 'B',
    title: 'Design that supports the pitch',
    text: 'The page now feels more premium, more spacious, and more aligned to a consultancy selling expertise rather than hours.',
  },
  {
    step: 'C',
    title: 'A better route to conversion',
    text: 'The content now leads naturally from problem, to proof, to next step, which is what a homepage should do.',
  },
]
</script>

<style scoped>
.home-page {
  position: relative;
  overflow: hidden;
  max-width: 1240px;
  margin: 0 auto;
  padding: 1.25rem 1rem 4rem;
  color: #1f1a1a;
  font-family: Inter, "Segoe UI", Arial, sans-serif;
}

.home-page::before,
.home-page::after {
  content: '';
  position: absolute;
  inset: auto;
  border-radius: 999px;
  pointer-events: none;
}

.home-page::before {
  top: -5rem;
  right: -4rem;
  width: 18rem;
  height: 18rem;
  background: radial-gradient(circle, rgba(209, 34, 41, 0.18), rgba(209, 34, 41, 0));
}

.home-page::after {
  bottom: 12rem;
  left: -6rem;
  width: 20rem;
  height: 20rem;
  background: radial-gradient(circle, rgba(128, 24, 27, 0.12), rgba(128, 24, 27, 0));
}

.hero-section,
.split-section {
  position: relative;
  z-index: 1;
}

.hero-section {
  display: grid;
  gap: 2rem;
  align-items: center;
  padding: 2rem 0 3rem;
}

.hero-copy h1,
.section-heading h2,
.quote-panel h2,
.cta-section h2 {
  margin: 0;
  font-family: Georgia, "Times New Roman", serif;
  letter-spacing: -0.03em;
  color: #170f10;
}

.hero-copy h1 {
  font-size: clamp(2.5rem, 8vw, 5rem);
  line-height: 0.98;
  max-width: 12ch;
}

.eyebrow {
  margin: 0 0 0.85rem;
  color: #9c1c24;
  text-transform: uppercase;
  letter-spacing: 0.18em;
  font-size: 0.74rem;
  font-weight: 800;
}

.hero-lede,
.section-heading p,
.quote-panel p,
.cta-section p,
.service-card p,
.case-card-body p,
.reason-card p,
.proof-card p {
  margin: 0;
  line-height: 1.7;
  color: #514548;
  font-size: 1rem;
}

.hero-lede {
  margin-top: 1.1rem;
  max-width: 42rem;
  font-size: 1.08rem;
}

.hero-actions {
  display: flex;
  flex-wrap: wrap;
  gap: 0.85rem;
  margin-top: 1.6rem;
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
  letter-spacing: 0.01em;
  transition: transform 0.2s ease, box-shadow 0.2s ease, background-color 0.2s ease;
}

.button:hover {
  transform: translateY(-1px);
}

.button-primary {
  background: linear-gradient(135deg, #b51721 0%, #e23d33 100%);
  color: #fff;
  box-shadow: 0 12px 30px rgba(178, 23, 33, 0.24);
}

.button-primary:hover {
  box-shadow: 0 16px 36px rgba(178, 23, 33, 0.28);
}

.button-secondary {
  background: rgba(255, 255, 255, 0.8);
  color: #7b151c;
  border: 1px solid rgba(123, 21, 28, 0.18);
}

.proof-strip {
  display: grid;
  gap: 1rem;
  margin-top: 1.75rem;
}

.proof-card,
.service-card,
.case-card,
.reason-card,
.quote-panel,
.cta-section {
  background: rgba(255, 255, 255, 0.84);
  backdrop-filter: blur(10px);
  border: 1px solid rgba(123, 21, 28, 0.09);
  box-shadow: 0 18px 45px rgba(31, 16, 18, 0.08);
}

.proof-card {
  border-radius: 1.4rem;
  padding: 1.15rem 1.15rem 1.2rem;
}

.proof-label,
.service-index,
.case-tag,
.reason-step {
  margin: 0 0 0.55rem;
  font-size: 0.72rem;
  font-weight: 800;
  text-transform: uppercase;
  letter-spacing: 0.16em;
  color: #9c1c24;
}

.proof-card h2,
.service-card h3,
.case-card h3,
.reason-card h3 {
  margin: 0 0 0.45rem;
  color: #170f10;
  line-height: 1.15;
}

.proof-card h2 {
  font-size: 1.1rem;
}

.hero-visual {
  position: relative;
  min-height: 28rem;
}

.hero-image-card {
  overflow: hidden;
  border-radius: 1.6rem;
  background: linear-gradient(180deg, #231516 0%, #0f0a0b 100%);
  box-shadow: 0 26px 60px rgba(35, 16, 18, 0.2);
}

.hero-image-card img {
  display: block;
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.hero-image-card-large {
  width: min(100%, 34rem);
  height: 24rem;
  margin-left: auto;
}

.hero-image-card-large img {
  opacity: 0.95;
}

.hero-image-card-small {
  position: absolute;
  left: 0;
  display: flex;
  align-items: center;
  gap: 0.95rem;
  width: min(85%, 22rem);
  padding: 0.75rem;
  color: #fff;
  border: 1px solid rgba(255, 255, 255, 0.12);
  background: rgba(20, 12, 13, 0.88);
}

.hero-image-card-small img {
  width: 5rem;
  height: 5rem;
  border-radius: 1rem;
  object-fit: cover;
}

.hero-image-card-small span {
  display: block;
  margin-bottom: 0.2rem;
  color: #f0b3b4;
  font-size: 0.72rem;
  font-weight: 800;
  text-transform: uppercase;
  letter-spacing: 0.15em;
}

.hero-image-card-small strong {
  display: block;
  font-size: 1rem;
  line-height: 1.25;
}

.hero-image-card-top {
  top: 1.5rem;
}

.hero-image-card-bottom {
  bottom: 1.5rem;
  left: 1.5rem;
}

.content-section {
  position: relative;
  z-index: 1;
  padding: 1.5rem 0 0;
}

.section-heading {
  max-width: 44rem;
  margin-bottom: 1.25rem;
}

.section-heading h2,
.quote-panel h2,
.cta-section h2 {
  font-size: clamp(1.9rem, 5vw, 3rem);
}

.section-heading p {
  margin-top: 0.8rem;
}

.services-grid,
.case-grid,
.split-section {
  display: grid;
  gap: 1rem;
}

.service-card,
.reason-card {
  border-radius: 1.4rem;
  padding: 1.35rem;
}

.service-card h3,
.case-card h3,
.reason-card h3 {
  font-size: 1.25rem;
}

.service-card ul {
  margin: 1rem 0 0;
  padding-left: 1.1rem;
  color: #514548;
  line-height: 1.7;
}

.service-card li + li {
  margin-top: 0.35rem;
}

.featured-section {
  padding-top: 2.5rem;
}

.section-heading-split {
  max-width: none;
}

.case-card {
  overflow: hidden;
  border-radius: 1.4rem;
}

.case-card-media {
  height: 14rem;
  background: #1a1112;
}

.case-card-media img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}

.case-card-body {
  padding: 1.25rem;
}

.case-card-body .text-link {
  display: inline-flex;
  margin-top: 0.9rem;
  color: #9c1c24;
  font-weight: 800;
  text-decoration: none;
}

.case-card-body .text-link:hover {
  text-decoration: underline;
}

.split-section {
  padding-top: 2.75rem;
}

.quote-panel {
  border-radius: 1.6rem;
  padding: 1.5rem;
}

.reason-list {
  display: grid;
  gap: 1rem;
}

.reason-card {
  border-radius: 1.2rem;
}

.cta-section {
  display: grid;
  gap: 1.2rem;
  align-items: center;
  margin-top: 2.75rem;
  border-radius: 1.8rem;
  padding: 1.5rem;
  background: linear-gradient(135deg, rgba(248, 239, 239, 0.95), rgba(255, 255, 255, 0.92));
}

.cta-button {
  justify-self: start;
}

@media (min-width: 720px) {
  .home-page {
    padding-inline: 1.5rem;
  }

  .proof-strip,
  .services-grid,
  .reason-list {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .case-grid {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .cta-section {
    grid-template-columns: minmax(0, 1fr) auto;
  }
}

@media (min-width: 1024px) {
  .home-page {
    padding: 2rem 2rem 5rem;
  }

  .hero-section {
    grid-template-columns: minmax(0, 1.05fr) minmax(0, 0.95fr);
    gap: 2.5rem;
    padding-top: 3rem;
  }

  .proof-strip {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .services-grid {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .section-heading-split,
  .split-section {
    grid-template-columns: minmax(0, 0.95fr) minmax(0, 1.05fr);
    align-items: start;
  }

  .case-grid {
    grid-template-columns: repeat(3, minmax(0, 1fr));
  }

  .reason-list {
    grid-template-columns: 1fr;
  }

  .cta-section {
    padding: 2rem;
  }
}

@media (min-width: 1200px) {
  .hero-image-card-large {
    height: 28rem;
  }

  .hero-image-card-small {
    width: 22rem;
  }
}

@media (prefers-reduced-motion: reduce) {
  .button {
    transition: none;
  }
}
</style>
