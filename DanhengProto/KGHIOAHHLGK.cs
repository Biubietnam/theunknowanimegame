using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009A1 RID: 2465
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KGHIOAHHLGK : IMessage<KGHIOAHHLGK>, IMessage, IEquatable<KGHIOAHHLGK>, IDeepCloneable<KGHIOAHHLGK>, IBufferMessage
	{
		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06006E31 RID: 28209 RVA: 0x00126694 File Offset: 0x00124894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KGHIOAHHLGK> Parser
		{
			get
			{
				return KGHIOAHHLGK._parser;
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06006E32 RID: 28210 RVA: 0x0012669B File Offset: 0x0012489B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KGHIOAHHLGKReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06006E33 RID: 28211 RVA: 0x001266AD File Offset: 0x001248AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KGHIOAHHLGK.Descriptor;
			}
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x001266B4 File Offset: 0x001248B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHIOAHHLGK()
		{
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x001266BC File Offset: 0x001248BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHIOAHHLGK(KGHIOAHHLGK other) : this()
		{
			this.maxScore_ = other.maxScore_;
			this.stageId_ = other.stageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x001266ED File Offset: 0x001248ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KGHIOAHHLGK Clone()
		{
			return new KGHIOAHHLGK(this);
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x06006E37 RID: 28215 RVA: 0x001266F5 File Offset: 0x001248F5
		// (set) Token: 0x06006E38 RID: 28216 RVA: 0x001266FD File Offset: 0x001248FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x06006E39 RID: 28217 RVA: 0x00126706 File Offset: 0x00124906
		// (set) Token: 0x06006E3A RID: 28218 RVA: 0x0012670E File Offset: 0x0012490E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint StageId
		{
			get
			{
				return this.stageId_;
			}
			set
			{
				this.stageId_ = value;
			}
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x00126717 File Offset: 0x00124917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KGHIOAHHLGK);
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x00126725 File Offset: 0x00124925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KGHIOAHHLGK other)
		{
			return other != null && (other == this || (this.MaxScore == other.MaxScore && this.StageId == other.StageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x00126764 File Offset: 0x00124964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this.StageId != 0U)
			{
				num ^= this.StageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x001267BC File Offset: 0x001249BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x001267C4 File Offset: 0x001249C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x001267D0 File Offset: 0x001249D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StageId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.StageId);
			}
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x0012682C File Offset: 0x00124A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this.StageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.StageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x00126884 File Offset: 0x00124A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KGHIOAHHLGK other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			if (other.StageId != 0U)
			{
				this.StageId = other.StageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x001268D4 File Offset: 0x00124AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x001268E0 File Offset: 0x00124AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxScore = input.ReadUInt32();
					}
				}
				else
				{
					this.StageId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002A52 RID: 10834
		private static readonly MessageParser<KGHIOAHHLGK> _parser = new MessageParser<KGHIOAHHLGK>(() => new KGHIOAHHLGK());

		// Token: 0x04002A53 RID: 10835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A54 RID: 10836
		public const int MaxScoreFieldNumber = 14;

		// Token: 0x04002A55 RID: 10837
		private uint maxScore_;

		// Token: 0x04002A56 RID: 10838
		public const int StageIdFieldNumber = 12;

		// Token: 0x04002A57 RID: 10839
		private uint stageId_;
	}
}
