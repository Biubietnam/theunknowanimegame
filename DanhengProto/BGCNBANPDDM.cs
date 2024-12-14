using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200011D RID: 285
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BGCNBANPDDM : IMessage<BGCNBANPDDM>, IMessage, IEquatable<BGCNBANPDDM>, IDeepCloneable<BGCNBANPDDM>, IBufferMessage
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CCD RID: 3277 RVA: 0x00026888 File Offset: 0x00024A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BGCNBANPDDM> Parser
		{
			get
			{
				return BGCNBANPDDM._parser;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0002688F File Offset: 0x00024A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BGCNBANPDDMReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CCF RID: 3279 RVA: 0x000268A1 File Offset: 0x00024AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BGCNBANPDDM.Descriptor;
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000268A8 File Offset: 0x00024AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BGCNBANPDDM()
		{
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x000268BB File Offset: 0x00024ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BGCNBANPDDM(BGCNBANPDDM other) : this()
		{
			this.aDFDGABFJEI_ = other.aDFDGABFJEI_.Clone();
			this.selectHintId_ = other.selectHintId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x000268F1 File Offset: 0x00024AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BGCNBANPDDM Clone()
		{
			return new BGCNBANPDDM(this);
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x000268F9 File Offset: 0x00024AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ADFDGABFJEI
		{
			get
			{
				return this.aDFDGABFJEI_;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00026901 File Offset: 0x00024B01
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00026909 File Offset: 0x00024B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x00026912 File Offset: 0x00024B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BGCNBANPDDM);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x00026920 File Offset: 0x00024B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BGCNBANPDDM other)
		{
			return other != null && (other == this || (this.aDFDGABFJEI_.Equals(other.aDFDGABFJEI_) && this.SelectHintId == other.SelectHintId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x00026970 File Offset: 0x00024B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aDFDGABFJEI_.GetHashCode();
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x000269BD File Offset: 0x00024BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x000269C5 File Offset: 0x00024BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x000269D0 File Offset: 0x00024BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aDFDGABFJEI_.WriteTo(ref output, BGCNBANPDDM._repeated_aDFDGABFJEI_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00026A20 File Offset: 0x00024C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aDFDGABFJEI_.CalculateSize(BGCNBANPDDM._repeated_aDFDGABFJEI_codec);
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00026A74 File Offset: 0x00024C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BGCNBANPDDM other)
		{
			if (other == null)
			{
				return;
			}
			this.aDFDGABFJEI_.Add(other.aDFDGABFJEI_);
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00026AC1 File Offset: 0x00024CC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00026ACC File Offset: 0x00024CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U && num != 98U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.aDFDGABFJEI_.AddEntriesFrom(ref input, BGCNBANPDDM._repeated_aDFDGABFJEI_codec);
				}
			}
		}

		// Token: 0x04000592 RID: 1426
		private static readonly MessageParser<BGCNBANPDDM> _parser = new MessageParser<BGCNBANPDDM>(() => new BGCNBANPDDM());

		// Token: 0x04000593 RID: 1427
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000594 RID: 1428
		public const int ADFDGABFJEIFieldNumber = 12;

		// Token: 0x04000595 RID: 1429
		private static readonly FieldCodec<uint> _repeated_aDFDGABFJEI_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04000596 RID: 1430
		private readonly RepeatedField<uint> aDFDGABFJEI_ = new RepeatedField<uint>();

		// Token: 0x04000597 RID: 1431
		public const int SelectHintIdFieldNumber = 13;

		// Token: 0x04000598 RID: 1432
		private uint selectHintId_;
	}
}
