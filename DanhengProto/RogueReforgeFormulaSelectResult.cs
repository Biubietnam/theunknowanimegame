using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F69 RID: 3945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueReforgeFormulaSelectResult : IMessage<RogueReforgeFormulaSelectResult>, IMessage, IEquatable<RogueReforgeFormulaSelectResult>, IDeepCloneable<RogueReforgeFormulaSelectResult>, IBufferMessage
	{
		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x0600AFD5 RID: 45013 RVA: 0x001D84E5 File Offset: 0x001D66E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueReforgeFormulaSelectResult> Parser
		{
			get
			{
				return RogueReforgeFormulaSelectResult._parser;
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x0600AFD6 RID: 45014 RVA: 0x001D84EC File Offset: 0x001D66EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003198 RID: 12696
		// (get) Token: 0x0600AFD7 RID: 45015 RVA: 0x001D84FE File Offset: 0x001D66FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueReforgeFormulaSelectResult.Descriptor;
			}
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x001D8505 File Offset: 0x001D6705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectResult()
		{
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x001D850D File Offset: 0x001D670D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectResult(RogueReforgeFormulaSelectResult other) : this()
		{
			this.tournFormulaId_ = other.tournFormulaId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFDA RID: 45018 RVA: 0x001D8532 File Offset: 0x001D6732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueReforgeFormulaSelectResult Clone()
		{
			return new RogueReforgeFormulaSelectResult(this);
		}

		// Token: 0x17003199 RID: 12697
		// (get) Token: 0x0600AFDB RID: 45019 RVA: 0x001D853A File Offset: 0x001D673A
		// (set) Token: 0x0600AFDC RID: 45020 RVA: 0x001D8542 File Offset: 0x001D6742
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TournFormulaId
		{
			get
			{
				return this.tournFormulaId_;
			}
			set
			{
				this.tournFormulaId_ = value;
			}
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x001D854B File Offset: 0x001D674B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueReforgeFormulaSelectResult);
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x001D8559 File Offset: 0x001D6759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueReforgeFormulaSelectResult other)
		{
			return other != null && (other == this || (this.TournFormulaId == other.TournFormulaId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x001D8588 File Offset: 0x001D6788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TournFormulaId != 0U)
			{
				num ^= this.TournFormulaId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x001D85C7 File Offset: 0x001D67C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x001D85CF File Offset: 0x001D67CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFE2 RID: 45026 RVA: 0x001D85D8 File Offset: 0x001D67D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TournFormulaId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFE3 RID: 45027 RVA: 0x001D860C File Offset: 0x001D680C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TournFormulaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TournFormulaId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFE4 RID: 45028 RVA: 0x001D864A File Offset: 0x001D684A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueReforgeFormulaSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TournFormulaId != 0U)
			{
				this.TournFormulaId = other.TournFormulaId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AFE5 RID: 45029 RVA: 0x001D867B File Offset: 0x001D687B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFE6 RID: 45030 RVA: 0x001D8684 File Offset: 0x001D6884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TournFormulaId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400477D RID: 18301
		private static readonly MessageParser<RogueReforgeFormulaSelectResult> _parser = new MessageParser<RogueReforgeFormulaSelectResult>(() => new RogueReforgeFormulaSelectResult());

		// Token: 0x0400477E RID: 18302
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400477F RID: 18303
		public const int TournFormulaIdFieldNumber = 12;

		// Token: 0x04004780 RID: 18304
		private uint tournFormulaId_;
	}
}
