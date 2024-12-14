using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001E9 RID: 489
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueBuffEnhanceList : IMessage<ChessRogueBuffEnhanceList>, IMessage, IEquatable<ChessRogueBuffEnhanceList>, IDeepCloneable<ChessRogueBuffEnhanceList>, IBufferMessage
	{
		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x0003ED03 File Offset: 0x0003CF03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueBuffEnhanceList> Parser
		{
			get
			{
				return ChessRogueBuffEnhanceList._parser;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x0003ED0A File Offset: 0x0003CF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceListReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x0003ED1C File Offset: 0x0003CF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueBuffEnhanceList.Descriptor;
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0003ED23 File Offset: 0x0003CF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceList()
		{
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0003ED36 File Offset: 0x0003CF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceList(ChessRogueBuffEnhanceList other) : this()
		{
			this.enhanceInfoList_ = other.enhanceInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0003ED60 File Offset: 0x0003CF60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffEnhanceList Clone()
		{
			return new ChessRogueBuffEnhanceList(this);
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x0003ED68 File Offset: 0x0003CF68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueBuffEnhanceInfo> EnhanceInfoList
		{
			get
			{
				return this.enhanceInfoList_;
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0003ED70 File Offset: 0x0003CF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueBuffEnhanceList);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0003ED7E File Offset: 0x0003CF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueBuffEnhanceList other)
		{
			return other != null && (other == this || (this.enhanceInfoList_.Equals(other.enhanceInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.enhanceInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x0003EDE8 File Offset: 0x0003CFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0003EDF0 File Offset: 0x0003CFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0003EDF9 File Offset: 0x0003CFF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.enhanceInfoList_.WriteTo(ref output, ChessRogueBuffEnhanceList._repeated_enhanceInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0003EE20 File Offset: 0x0003D020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.enhanceInfoList_.CalculateSize(ChessRogueBuffEnhanceList._repeated_enhanceInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x0003EE59 File Offset: 0x0003D059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueBuffEnhanceList other)
		{
			if (other == null)
			{
				return;
			}
			this.enhanceInfoList_.Add(other.enhanceInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0003EE87 File Offset: 0x0003D087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0003EE90 File Offset: 0x0003D090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.enhanceInfoList_.AddEntriesFrom(ref input, ChessRogueBuffEnhanceList._repeated_enhanceInfoList_codec);
				}
			}
		}

		// Token: 0x04000939 RID: 2361
		private static readonly MessageParser<ChessRogueBuffEnhanceList> _parser = new MessageParser<ChessRogueBuffEnhanceList>(() => new ChessRogueBuffEnhanceList());

		// Token: 0x0400093A RID: 2362
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400093B RID: 2363
		public const int EnhanceInfoListFieldNumber = 10;

		// Token: 0x0400093C RID: 2364
		private static readonly FieldCodec<ChessRogueBuffEnhanceInfo> _repeated_enhanceInfoList_codec = FieldCodec.ForMessage<ChessRogueBuffEnhanceInfo>(82U, ChessRogueBuffEnhanceInfo.Parser);

		// Token: 0x0400093D RID: 2365
		private readonly RepeatedField<ChessRogueBuffEnhanceInfo> enhanceInfoList_ = new RepeatedField<ChessRogueBuffEnhanceInfo>();
	}
}
