<template>
  <div class="contact-page">
    <section class="contact-hero">
      <div class="contact-hero-copy">
        <p class="eyebrow">Contact</p>
        <h1>Start with the problem, the systems, or the outcome you need.</h1>
        <p>
          Red Shoes Technology works best on projects where technical depth, plain English, and practical delivery all matter. Send a brief and we will respond with a clear next step.
        </p>
      </div>

      <div class="contact-hero-card">
        <p class="contact-card-label">Direct contact</p>
        <a href="mailto:info@redshoestechnology.com.au">info@redshoestechnology.com.au</a>
        <a href="tel:0433265783">0433 265 783</a>
        <p>Melbourne, Victoria</p>
      </div>
    </section>

    <section class="contact-layout">
      <form class="contact-form-panel" @submit.prevent="submitForm">
        <div class="panel-heading">
          <p class="eyebrow">Project enquiry</p>
          <h2>Tell us what you are trying to improve.</h2>
        </div>

        <div class="contact-grid">
          <label>
            <span>Name</span>
            <input v-model="form.name" type="text" placeholder="Your name" />
          </label>

          <label>
            <span>Email</span>
            <input v-model="form.emailAddress" type="email" placeholder="you@company.com" />
          </label>

          <label>
            <span>Phone</span>
            <input v-model="form.phoneNumber" type="tel" placeholder="Optional" />
          </label>

          <label>
            <span>Location</span>
            <input v-model="form.address" type="text" placeholder="City or region" />
          </label>

          <label class="contact-grid-wide">
            <span>Subject</span>
            <input v-model="form.subject" type="text" placeholder="What would you like help with?" />
          </label>

          <label class="contact-grid-wide">
            <span>Message</span>
            <textarea v-model="form.message" rows="7" placeholder="Share a short summary of the challenge, timeline, or system involved."></textarea>
          </label>
        </div>

        <button type="submit" class="button button-primary submit-btn">Send enquiry</button>
      </form>

      <aside class="contact-aside">
        <article class="aside-card">
          <p class="eyebrow">What to include</p>
          <ul>
            <li>The system or workflow that is causing friction.</li>
            <li>What a better outcome would look like.</li>
            <li>Any deadlines, constraints, or dependencies.</li>
          </ul>
        </article>

        <article class="aside-card aside-highlight">
          <p class="eyebrow">Response style</p>
          <h2>Direct, honest, and practical.</h2>
          <p>
            If the project is a fit, we will say so and suggest a sensible first step. If it is not, we will still try to point you in the right direction.
          </p>
        </article>

        <article class="aside-card">
          <p class="eyebrow">LinkedIn</p>
          <a class="linkedin-link" href="https://www.linkedin.com/company/red-shoes-technology/" target="_blank" rel="noopener">
            Follow Red Shoes Technology
          </a>
        </article>
      </aside>
    </section>

    <div v-if="showStatusBox" class="popup-overlay">
      <div class="popup-content">
        <button
          v-if="status === 'error' || status === 'success'"
          @click="showStatusBox = false"
          class="popup-close"
          aria-label="Close"
        >×</button>
        <div v-if="status === 'sending'">
          <span class="popup-text">Sending your message...</span>
        </div>
        <div v-else-if="status === 'success'">
          <span class="popup-text success">Your message has been sent!</span>
        </div>
        <div v-else-if="status === 'error'">
          <span class="popup-text error">
            Failed to send message.<br>
            Please phone <b>0433 265 783</b> or email <br><b>info@redshoestechnology.com.au</b> directly.
          </span>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { reactive, ref } from 'vue'

const apiKey = import.meta.env.VITE_API_KEY

const form = reactive({
  name: '',
  emailAddress: '',
  phoneNumber: '',
  address: '',
  subject: '',
  message: ''
})

const showStatusBox = ref(false)
const status = ref('sending')
let autoCloseTimeout = null

async function submitForm() {
  showStatusBox.value = true
  status.value = 'sending'
  try {
    const response = await fetch('/api/email', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json',
        'X-API-KEY': apiKey
      },
      body: JSON.stringify({
        name: form.name,
        emailAddress: form.emailAddress,
        phoneNumber: form.phoneNumber,
        address: form.address,
        subject: form.subject,
        message: form.message
      })
    })
    if (!response.ok) throw new Error('Failed to send')
    status.value = 'success'
    form.name = ''
    form.emailAddress = ''
    form.phoneNumber = ''
    form.address = ''
    form.subject = ''
    form.message = ''
    if (autoCloseTimeout) clearTimeout(autoCloseTimeout)
    autoCloseTimeout = setTimeout(() => {
      showStatusBox.value = false
    }, 3000)
  } catch (error) {
    status.value = 'error'
  }
}
</script>

<style scoped>
.contact-page {
  max-width: 1240px;
  margin: 0 auto;
  padding: 1.25rem 1rem 4rem;
  color: #1f1a1a;
  font-family: Inter, "Segoe UI", Arial, sans-serif;
}

.contact-hero,
.contact-layout {
  display: grid;
  gap: 1rem;
}

.contact-hero {
  padding: 2rem 0 1.5rem;
}

.contact-hero-copy,
.contact-hero-card,
.contact-form-panel,
.aside-card {
  background: rgba(255, 255, 255, 0.88);
  border: 1px solid rgba(123, 21, 28, 0.09);
  box-shadow: 0 18px 45px rgba(31, 16, 18, 0.08);
  backdrop-filter: blur(10px);
  border-radius: 1.5rem;
}

.contact-hero-copy,
.contact-hero-card,
.contact-form-panel,
.aside-card {
  padding: 1.5rem;
}

.contact-hero-card {
  display: grid;
  gap: 0.6rem;
}

.contact-hero-card a,
.linkedin-link {
  color: #7b151c;
  font-weight: 800;
  text-decoration: none;
}

.contact-hero-card a:hover,
.linkedin-link:hover {
  text-decoration: underline;
}

.contact-page h1,
.panel-heading h2,
.aside-highlight h2 {
  margin: 0;
  font-family: Georgia, "Times New Roman", serif;
  letter-spacing: -0.03em;
  color: #170f10;
}

.contact-page h1 {
  font-size: clamp(2.4rem, 7vw, 4.6rem);
  line-height: 0.98;
  max-width: 12ch;
}

.contact-page p,
.aside-card p,
.aside-card li,
.contact-hero-card p,
.popup-text {
  margin: 0;
  color: #514548;
  line-height: 1.7;
}

.eyebrow,
.contact-card-label {
  margin: 0 0 0.85rem;
  color: #9c1c24;
  text-transform: uppercase;
  letter-spacing: 0.18em;
  font-size: 0.74rem;
  font-weight: 800;
}

.panel-heading {
  max-width: 40rem;
  margin-bottom: 1.25rem;
}

.panel-heading h2 {
  font-size: clamp(1.8rem, 4.5vw, 2.6rem);
}

.contact-grid {
  display: grid;
  gap: 1rem;
}

.contact-grid label {
  display: grid;
  gap: 0.45rem;
  font-weight: 700;
  color: #170f10;
}

.contact-grid span {
  font-size: 0.92rem;
}

.contact-grid input,
.contact-grid textarea {
  width: 100%;
  border-radius: 1rem;
  border: 1px solid rgba(123, 21, 28, 0.16);
  padding: 0.95rem 1rem;
  background: #fff;
  color: #170f10;
  font: inherit;
}

.contact-grid textarea {
  resize: vertical;
  min-height: 10rem;
}

.contact-grid-wide {
  grid-column: 1 / -1;
}

.submit-btn {
  margin-top: 1.25rem;
}

.contact-aside {
  display: grid;
  gap: 1rem;
}

.aside-card ul {
  margin: 0;
  padding-left: 1.1rem;
  color: #514548;
  line-height: 1.7;
}

.aside-card li + li {
  margin-top: 0.35rem;
}

.aside-highlight h2 {
  font-size: 1.4rem;
  margin-bottom: 0.5rem;
}

.popup-overlay {
  position: fixed;
  inset: 0;
  background: rgba(18, 12, 13, 0.55);
  display: grid;
  place-items: center;
  padding: 1rem;
  z-index: 9999;
}

.popup-content {
  position: relative;
  max-width: 28rem;
  width: 100%;
  background: #fff;
  color: #170f10;
  border-radius: 1.25rem;
  padding: 1.5rem;
  box-shadow: 0 20px 50px rgba(31, 16, 18, 0.25);
}

.popup-close {
  position: absolute;
  top: 0.85rem;
  right: 1rem;
  border: none;
  background: transparent;
  color: #7b151c;
  font-size: 2rem;
  cursor: pointer;
}

.popup-text.success {
  color: #0f7a39;
}

.popup-text.error {
  color: #b91c1c;
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
  .contact-page {
    padding: 2rem 2rem 5rem;
  }

  .contact-hero {
    grid-template-columns: minmax(0, 1.15fr) minmax(18rem, 0.85fr);
    align-items: stretch;
    gap: 1.25rem;
    padding-top: 3rem;
  }

  .contact-layout {
    grid-template-columns: minmax(0, 1.15fr) minmax(18rem, 0.85fr);
    align-items: start;
  }

  .contact-grid {
    grid-template-columns: repeat(2, minmax(0, 1fr));
  }

  .contact-grid-wide {
    grid-column: 1 / -1;
  }
}
</style>

