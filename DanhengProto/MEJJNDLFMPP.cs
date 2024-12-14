using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ABF RID: 2751
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MEJJNDLFMPP : IMessage<MEJJNDLFMPP>, IMessage, IEquatable<MEJJNDLFMPP>, IDeepCloneable<MEJJNDLFMPP>, IBufferMessage
	{
		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06007A00 RID: 31232 RVA: 0x00143260 File Offset: 0x00141460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MEJJNDLFMPP> Parser
		{
			get
			{
				return MEJJNDLFMPP._parser;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x06007A01 RID: 31233 RVA: 0x00143267 File Offset: 0x00141467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MEJJNDLFMPPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x06007A02 RID: 31234 RVA: 0x00143279 File Offset: 0x00141479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MEJJNDLFMPP.Descriptor;
			}
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x00143280 File Offset: 0x00141480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MEJJNDLFMPP()
		{
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x00143288 File Offset: 0x00141488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MEJJNDLFMPP(MEJJNDLFMPP other) : this()
		{
			this.pAEHKCNCOHI_ = other.pAEHKCNCOHI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x001432AD File Offset: 0x001414AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MEJJNDLFMPP Clone()
		{
			return new MEJJNDLFMPP(this);
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x001432B5 File Offset: 0x001414B5
		// (set) Token: 0x06007A07 RID: 31239 RVA: 0x001432BD File Offset: 0x001414BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PAEHKCNCOHI
		{
			get
			{
				return this.pAEHKCNCOHI_;
			}
			set
			{
				this.pAEHKCNCOHI_ = value;
			}
		}

		// Token: 0x06007A08 RID: 31240 RVA: 0x001432C6 File Offset: 0x001414C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MEJJNDLFMPP);
		}

		// Token: 0x06007A09 RID: 31241 RVA: 0x001432D4 File Offset: 0x001414D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MEJJNDLFMPP other)
		{
			return other != null && (other == this || (this.PAEHKCNCOHI == other.PAEHKCNCOHI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A0A RID: 31242 RVA: 0x00143304 File Offset: 0x00141504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PAEHKCNCOHI != 0U)
			{
				num ^= this.PAEHKCNCOHI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A0B RID: 31243 RVA: 0x00143343 File Offset: 0x00141543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A0C RID: 31244 RVA: 0x0014334B File Offset: 0x0014154B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A0D RID: 31245 RVA: 0x00143354 File Offset: 0x00141554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PAEHKCNCOHI != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.PAEHKCNCOHI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x00143388 File Offset: 0x00141588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PAEHKCNCOHI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PAEHKCNCOHI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x001433C6 File Offset: 0x001415C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MEJJNDLFMPP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PAEHKCNCOHI != 0U)
			{
				this.PAEHKCNCOHI = other.PAEHKCNCOHI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x001433F7 File Offset: 0x001415F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x00143400 File Offset: 0x00141600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PAEHKCNCOHI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002ECD RID: 11981
		private static readonly MessageParser<MEJJNDLFMPP> _parser = new MessageParser<MEJJNDLFMPP>(() => new MEJJNDLFMPP());

		// Token: 0x04002ECE RID: 11982
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002ECF RID: 11983
		public const int PAEHKCNCOHIFieldNumber = 4;

		// Token: 0x04002ED0 RID: 11984
		private uint pAEHKCNCOHI_;
	}
}
