using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B5 RID: 181
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AssistMonsterEntityInfo : IMessage<AssistMonsterEntityInfo>, IMessage, IEquatable<AssistMonsterEntityInfo>, IDeepCloneable<AssistMonsterEntityInfo>, IBufferMessage
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00015ED4 File Offset: 0x000140D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AssistMonsterEntityInfo> Parser
		{
			get
			{
				return AssistMonsterEntityInfo._parser;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00015EDB File Offset: 0x000140DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AssistMonsterEntityInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00015EED File Offset: 0x000140ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssistMonsterEntityInfo.Descriptor;
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00015EF4 File Offset: 0x000140F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistMonsterEntityInfo()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00015F07 File Offset: 0x00014107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistMonsterEntityInfo(AssistMonsterEntityInfo other) : this()
		{
			this.entityIdList_ = other.entityIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00015F31 File Offset: 0x00014131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistMonsterEntityInfo Clone()
		{
			return new AssistMonsterEntityInfo(this);
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00015F39 File Offset: 0x00014139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntityIdList
		{
			get
			{
				return this.entityIdList_;
			}
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00015F41 File Offset: 0x00014141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssistMonsterEntityInfo);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00015F4F File Offset: 0x0001414F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AssistMonsterEntityInfo other)
		{
			return other != null && (other == this || (this.entityIdList_.Equals(other.entityIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00015F84 File Offset: 0x00014184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00015FB8 File Offset: 0x000141B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x00015FC0 File Offset: 0x000141C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00015FC9 File Offset: 0x000141C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityIdList_.WriteTo(ref output, AssistMonsterEntityInfo._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00015FF0 File Offset: 0x000141F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityIdList_.CalculateSize(AssistMonsterEntityInfo._repeated_entityIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00016029 File Offset: 0x00014229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AssistMonsterEntityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.entityIdList_.Add(other.entityIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00016057 File Offset: 0x00014257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00016060 File Offset: 0x00014260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityIdList_.AddEntriesFrom(ref input, AssistMonsterEntityInfo._repeated_entityIdList_codec);
				}
			}
		}

		// Token: 0x040002EA RID: 746
		private static readonly MessageParser<AssistMonsterEntityInfo> _parser = new MessageParser<AssistMonsterEntityInfo>(() => new AssistMonsterEntityInfo());

		// Token: 0x040002EB RID: 747
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002EC RID: 748
		public const int EntityIdListFieldNumber = 12;

		// Token: 0x040002ED RID: 749
		private static readonly FieldCodec<uint> _repeated_entityIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x040002EE RID: 750
		private readonly RepeatedField<uint> entityIdList_ = new RepeatedField<uint>();
	}
}
