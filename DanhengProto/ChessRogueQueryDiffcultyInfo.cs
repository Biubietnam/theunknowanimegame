using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000279 RID: 633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryDiffcultyInfo : IMessage<ChessRogueQueryDiffcultyInfo>, IMessage, IEquatable<ChessRogueQueryDiffcultyInfo>, IDeepCloneable<ChessRogueQueryDiffcultyInfo>, IBufferMessage
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00050BC1 File Offset: 0x0004EDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryDiffcultyInfo> Parser
		{
			get
			{
				return ChessRogueQueryDiffcultyInfo._parser;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001C33 RID: 7219 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryDiffcultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00050BDA File Offset: 0x0004EDDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryDiffcultyInfo.Descriptor;
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00050BE1 File Offset: 0x0004EDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiffcultyInfo()
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00050BF4 File Offset: 0x0004EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiffcultyInfo(ChessRogueQueryDiffcultyInfo other) : this()
		{
			this.queryDifficultyIdList_ = other.queryDifficultyIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00050C1E File Offset: 0x0004EE1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryDiffcultyInfo Clone()
		{
			return new ChessRogueQueryDiffcultyInfo(this);
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00050C26 File Offset: 0x0004EE26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> QueryDifficultyIdList
		{
			get
			{
				return this.queryDifficultyIdList_;
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00050C2E File Offset: 0x0004EE2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryDiffcultyInfo);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00050C3C File Offset: 0x0004EE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryDiffcultyInfo other)
		{
			return other != null && (other == this || (this.queryDifficultyIdList_.Equals(other.queryDifficultyIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00050C70 File Offset: 0x0004EE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.queryDifficultyIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00050CA4 File Offset: 0x0004EEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00050CAC File Offset: 0x0004EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00050CB5 File Offset: 0x0004EEB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.queryDifficultyIdList_.WriteTo(ref output, ChessRogueQueryDiffcultyInfo._repeated_queryDifficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00050CDC File Offset: 0x0004EEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.queryDifficultyIdList_.CalculateSize(ChessRogueQueryDiffcultyInfo._repeated_queryDifficultyIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00050D15 File Offset: 0x0004EF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryDiffcultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.queryDifficultyIdList_.Add(other.queryDifficultyIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00050D43 File Offset: 0x0004EF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00050D4C File Offset: 0x0004EF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.queryDifficultyIdList_.AddEntriesFrom(ref input, ChessRogueQueryDiffcultyInfo._repeated_queryDifficultyIdList_codec);
				}
			}
		}

		// Token: 0x04000BC9 RID: 3017
		private static readonly MessageParser<ChessRogueQueryDiffcultyInfo> _parser = new MessageParser<ChessRogueQueryDiffcultyInfo>(() => new ChessRogueQueryDiffcultyInfo());

		// Token: 0x04000BCA RID: 3018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BCB RID: 3019
		public const int QueryDifficultyIdListFieldNumber = 14;

		// Token: 0x04000BCC RID: 3020
		private static readonly FieldCodec<uint> _repeated_queryDifficultyIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04000BCD RID: 3021
		private readonly RepeatedField<uint> queryDifficultyIdList_ = new RepeatedField<uint>();
	}
}
