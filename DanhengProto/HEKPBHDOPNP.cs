using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008AF RID: 2223
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HEKPBHDOPNP : IMessage<HEKPBHDOPNP>, IMessage, IEquatable<HEKPBHDOPNP>, IDeepCloneable<HEKPBHDOPNP>, IBufferMessage
	{
		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06006304 RID: 25348 RVA: 0x001090F9 File Offset: 0x001072F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HEKPBHDOPNP> Parser
		{
			get
			{
				return HEKPBHDOPNP._parser;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06006305 RID: 25349 RVA: 0x00109100 File Offset: 0x00107300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HEKPBHDOPNPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06006306 RID: 25350 RVA: 0x00109112 File Offset: 0x00107312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HEKPBHDOPNP.Descriptor;
			}
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x00109119 File Offset: 0x00107319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEKPBHDOPNP()
		{
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x0010912C File Offset: 0x0010732C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEKPBHDOPNP(HEKPBHDOPNP other) : this()
		{
			this.eventId_ = other.eventId_;
			this.dAHLECFLJCI_ = other.dAHLECFLJCI_;
			this.kFJCGMAFANN_ = other.kFJCGMAFANN_.Clone();
			this.bMBOLAAHCNC_ = other.bMBOLAAHCNC_;
			this.bINLNAGFFEP_ = other.bINLNAGFFEP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x00109191 File Offset: 0x00107391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HEKPBHDOPNP Clone()
		{
			return new HEKPBHDOPNP(this);
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x0600630A RID: 25354 RVA: 0x00109199 File Offset: 0x00107399
		// (set) Token: 0x0600630B RID: 25355 RVA: 0x001091A1 File Offset: 0x001073A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600630C RID: 25356 RVA: 0x001091AA File Offset: 0x001073AA
		// (set) Token: 0x0600630D RID: 25357 RVA: 0x001091B2 File Offset: 0x001073B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DAHLECFLJCI
		{
			get
			{
				return this.dAHLECFLJCI_;
			}
			set
			{
				this.dAHLECFLJCI_ = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x001091BB File Offset: 0x001073BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KFJCGMAFANN
		{
			get
			{
				return this.kFJCGMAFANN_;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x0600630F RID: 25359 RVA: 0x001091C3 File Offset: 0x001073C3
		// (set) Token: 0x06006310 RID: 25360 RVA: 0x001091CB File Offset: 0x001073CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BMBOLAAHCNC
		{
			get
			{
				return this.bMBOLAAHCNC_;
			}
			set
			{
				this.bMBOLAAHCNC_ = value;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06006311 RID: 25361 RVA: 0x001091D4 File Offset: 0x001073D4
		// (set) Token: 0x06006312 RID: 25362 RVA: 0x001091DC File Offset: 0x001073DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BINLNAGFFEP
		{
			get
			{
				return this.bINLNAGFFEP_;
			}
			set
			{
				this.bINLNAGFFEP_ = value;
			}
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x001091E5 File Offset: 0x001073E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HEKPBHDOPNP);
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x001091F4 File Offset: 0x001073F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HEKPBHDOPNP other)
		{
			return other != null && (other == this || (this.EventId == other.EventId && this.DAHLECFLJCI == other.DAHLECFLJCI && this.kFJCGMAFANN_.Equals(other.kFJCGMAFANN_) && this.BMBOLAAHCNC == other.BMBOLAAHCNC && this.BINLNAGFFEP == other.BINLNAGFFEP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x00109274 File Offset: 0x00107474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.DAHLECFLJCI != 0U)
			{
				num ^= this.DAHLECFLJCI.GetHashCode();
			}
			num ^= this.kFJCGMAFANN_.GetHashCode();
			if (this.BMBOLAAHCNC != 0U)
			{
				num ^= this.BMBOLAAHCNC.GetHashCode();
			}
			if (this.BINLNAGFFEP != 0U)
			{
				num ^= this.BINLNAGFFEP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x0010930C File Offset: 0x0010750C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006317 RID: 25367 RVA: 0x00109314 File Offset: 0x00107514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x00109320 File Offset: 0x00107520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BINLNAGFFEP != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.BINLNAGFFEP);
			}
			this.kFJCGMAFANN_.WriteTo(ref output, HEKPBHDOPNP._repeated_kFJCGMAFANN_codec);
			if (this.BMBOLAAHCNC != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.BMBOLAAHCNC);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EventId);
			}
			if (this.DAHLECFLJCI != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DAHLECFLJCI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x001093C4 File Offset: 0x001075C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this.DAHLECFLJCI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DAHLECFLJCI);
			}
			num += this.kFJCGMAFANN_.CalculateSize(HEKPBHDOPNP._repeated_kFJCGMAFANN_codec);
			if (this.BMBOLAAHCNC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BMBOLAAHCNC);
			}
			if (this.BINLNAGFFEP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BINLNAGFFEP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x00109460 File Offset: 0x00107660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HEKPBHDOPNP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			if (other.DAHLECFLJCI != 0U)
			{
				this.DAHLECFLJCI = other.DAHLECFLJCI;
			}
			this.kFJCGMAFANN_.Add(other.kFJCGMAFANN_);
			if (other.BMBOLAAHCNC != 0U)
			{
				this.BMBOLAAHCNC = other.BMBOLAAHCNC;
			}
			if (other.BINLNAGFFEP != 0U)
			{
				this.BINLNAGFFEP = other.BINLNAGFFEP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x001094E9 File Offset: 0x001076E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x001094F4 File Offset: 0x001076F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.BINLNAGFFEP = input.ReadUInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.kFJCGMAFANN_.AddEntriesFrom(ref input, HEKPBHDOPNP._repeated_kFJCGMAFANN_codec);
						continue;
					}
				}
				else
				{
					if (num == 40U)
					{
						this.BMBOLAAHCNC = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.DAHLECFLJCI = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400261F RID: 9759
		private static readonly MessageParser<HEKPBHDOPNP> _parser = new MessageParser<HEKPBHDOPNP>(() => new HEKPBHDOPNP());

		// Token: 0x04002620 RID: 9760
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002621 RID: 9761
		public const int EventIdFieldNumber = 9;

		// Token: 0x04002622 RID: 9762
		private uint eventId_;

		// Token: 0x04002623 RID: 9763
		public const int DAHLECFLJCIFieldNumber = 11;

		// Token: 0x04002624 RID: 9764
		private uint dAHLECFLJCI_;

		// Token: 0x04002625 RID: 9765
		public const int KFJCGMAFANNFieldNumber = 4;

		// Token: 0x04002626 RID: 9766
		private static readonly FieldCodec<uint> _repeated_kFJCGMAFANN_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04002627 RID: 9767
		private readonly RepeatedField<uint> kFJCGMAFANN_ = new RepeatedField<uint>();

		// Token: 0x04002628 RID: 9768
		public const int BMBOLAAHCNCFieldNumber = 5;

		// Token: 0x04002629 RID: 9769
		private uint bMBOLAAHCNC_;

		// Token: 0x0400262A RID: 9770
		public const int BINLNAGFFEPFieldNumber = 3;

		// Token: 0x0400262B RID: 9771
		private uint bINLNAGFFEP_;
	}
}
