using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A77 RID: 2679
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MakeDrinkCsReq : IMessage<MakeDrinkCsReq>, IMessage, IEquatable<MakeDrinkCsReq>, IDeepCloneable<MakeDrinkCsReq>, IBufferMessage
	{
		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x060076B7 RID: 30391 RVA: 0x0013B069 File Offset: 0x00139269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MakeDrinkCsReq> Parser
		{
			get
			{
				return MakeDrinkCsReq._parser;
			}
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x0013B070 File Offset: 0x00139270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MakeDrinkCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x060076B9 RID: 30393 RVA: 0x0013B082 File Offset: 0x00139282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MakeDrinkCsReq.Descriptor;
			}
		}

		// Token: 0x060076BA RID: 30394 RVA: 0x0013B089 File Offset: 0x00139289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkCsReq()
		{
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x0013B094 File Offset: 0x00139294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkCsReq(MakeDrinkCsReq other) : this()
		{
			this.oEEHEOKKNGD_ = ((other.oEEHEOKKNGD_ != null) ? other.oEEHEOKKNGD_.Clone() : null);
			this.fAABGHNMGHM_ = other.fAABGHNMGHM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x0013B0E0 File Offset: 0x001392E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkCsReq Clone()
		{
			return new MakeDrinkCsReq(this);
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x060076BD RID: 30397 RVA: 0x0013B0E8 File Offset: 0x001392E8
		// (set) Token: 0x060076BE RID: 30398 RVA: 0x0013B0F0 File Offset: 0x001392F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LGNIOADJNOJ OEEHEOKKNGD
		{
			get
			{
				return this.oEEHEOKKNGD_;
			}
			set
			{
				this.oEEHEOKKNGD_ = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x0013B0F9 File Offset: 0x001392F9
		// (set) Token: 0x060076C0 RID: 30400 RVA: 0x0013B101 File Offset: 0x00139301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FAABGHNMGHM
		{
			get
			{
				return this.fAABGHNMGHM_;
			}
			set
			{
				this.fAABGHNMGHM_ = value;
			}
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x0013B10A File Offset: 0x0013930A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MakeDrinkCsReq);
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x0013B118 File Offset: 0x00139318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MakeDrinkCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.OEEHEOKKNGD, other.OEEHEOKKNGD) && this.FAABGHNMGHM == other.FAABGHNMGHM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x0013B168 File Offset: 0x00139368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.oEEHEOKKNGD_ != null)
			{
				num ^= this.OEEHEOKKNGD.GetHashCode();
			}
			if (this.FAABGHNMGHM != 0U)
			{
				num ^= this.FAABGHNMGHM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x0013B1BD File Offset: 0x001393BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076C5 RID: 30405 RVA: 0x0013B1C5 File Offset: 0x001393C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x0013B1D0 File Offset: 0x001393D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FAABGHNMGHM != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FAABGHNMGHM);
			}
			if (this.oEEHEOKKNGD_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.OEEHEOKKNGD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x0013B22C File Offset: 0x0013942C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.oEEHEOKKNGD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OEEHEOKKNGD);
			}
			if (this.FAABGHNMGHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FAABGHNMGHM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x0013B284 File Offset: 0x00139484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MakeDrinkCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.oEEHEOKKNGD_ != null)
			{
				if (this.oEEHEOKKNGD_ == null)
				{
					this.OEEHEOKKNGD = new LGNIOADJNOJ();
				}
				this.OEEHEOKKNGD.MergeFrom(other.OEEHEOKKNGD);
			}
			if (other.FAABGHNMGHM != 0U)
			{
				this.FAABGHNMGHM = other.FAABGHNMGHM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x0013B2EC File Offset: 0x001394EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x0013B2F8 File Offset: 0x001394F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.oEEHEOKKNGD_ == null)
						{
							this.OEEHEOKKNGD = new LGNIOADJNOJ();
						}
						input.ReadMessage(this.OEEHEOKKNGD);
					}
				}
				else
				{
					this.FAABGHNMGHM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D9F RID: 11679
		private static readonly MessageParser<MakeDrinkCsReq> _parser = new MessageParser<MakeDrinkCsReq>(() => new MakeDrinkCsReq());

		// Token: 0x04002DA0 RID: 11680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DA1 RID: 11681
		public const int OEEHEOKKNGDFieldNumber = 14;

		// Token: 0x04002DA2 RID: 11682
		private LGNIOADJNOJ oEEHEOKKNGD_;

		// Token: 0x04002DA3 RID: 11683
		public const int FAABGHNMGHMFieldNumber = 10;

		// Token: 0x04002DA4 RID: 11684
		private uint fAABGHNMGHM_;
	}
}
