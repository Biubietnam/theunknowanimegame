using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E13 RID: 3603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueBonusSelectResult : IMessage<RogueBonusSelectResult>, IMessage, IEquatable<RogueBonusSelectResult>, IDeepCloneable<RogueBonusSelectResult>, IBufferMessage
	{
		// Token: 0x17002D73 RID: 11635
		// (get) Token: 0x0600A101 RID: 41217 RVA: 0x001AFCD0 File Offset: 0x001ADED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueBonusSelectResult> Parser
		{
			get
			{
				return RogueBonusSelectResult._parser;
			}
		}

		// Token: 0x17002D74 RID: 11636
		// (get) Token: 0x0600A102 RID: 41218 RVA: 0x001AFCD7 File Offset: 0x001ADED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueBonusSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D75 RID: 11637
		// (get) Token: 0x0600A103 RID: 41219 RVA: 0x001AFCE9 File Offset: 0x001ADEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBonusSelectResult.Descriptor;
			}
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x001AFCF0 File Offset: 0x001ADEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectResult()
		{
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x001AFCF8 File Offset: 0x001ADEF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectResult(RogueBonusSelectResult other) : this()
		{
			this.bonusId_ = other.bonusId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x001AFD1D File Offset: 0x001ADF1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBonusSelectResult Clone()
		{
			return new RogueBonusSelectResult(this);
		}

		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0600A107 RID: 41223 RVA: 0x001AFD25 File Offset: 0x001ADF25
		// (set) Token: 0x0600A108 RID: 41224 RVA: 0x001AFD2D File Offset: 0x001ADF2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BonusId
		{
			get
			{
				return this.bonusId_;
			}
			set
			{
				this.bonusId_ = value;
			}
		}

		// Token: 0x0600A109 RID: 41225 RVA: 0x001AFD36 File Offset: 0x001ADF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBonusSelectResult);
		}

		// Token: 0x0600A10A RID: 41226 RVA: 0x001AFD44 File Offset: 0x001ADF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBonusSelectResult other)
		{
			return other != null && (other == this || (this.BonusId == other.BonusId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A10B RID: 41227 RVA: 0x001AFD74 File Offset: 0x001ADF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BonusId != 0U)
			{
				num ^= this.BonusId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A10C RID: 41228 RVA: 0x001AFDB3 File Offset: 0x001ADFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A10D RID: 41229 RVA: 0x001AFDBB File Offset: 0x001ADFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A10E RID: 41230 RVA: 0x001AFDC4 File Offset: 0x001ADFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BonusId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BonusId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A10F RID: 41231 RVA: 0x001AFDF8 File Offset: 0x001ADFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BonusId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BonusId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A110 RID: 41232 RVA: 0x001AFE36 File Offset: 0x001AE036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBonusSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BonusId != 0U)
			{
				this.BonusId = other.BonusId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A111 RID: 41233 RVA: 0x001AFE67 File Offset: 0x001AE067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A112 RID: 41234 RVA: 0x001AFE70 File Offset: 0x001AE070
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
					this.BonusId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040041EC RID: 16876
		private static readonly MessageParser<RogueBonusSelectResult> _parser = new MessageParser<RogueBonusSelectResult>(() => new RogueBonusSelectResult());

		// Token: 0x040041ED RID: 16877
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041EE RID: 16878
		public const int BonusIdFieldNumber = 12;

		// Token: 0x040041EF RID: 16879
		private uint bonusId_;
	}
}
