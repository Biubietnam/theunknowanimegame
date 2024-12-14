using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000841 RID: 2113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetUnlockTeleportCsReq : IMessage<GetUnlockTeleportCsReq>, IMessage, IEquatable<GetUnlockTeleportCsReq>, IDeepCloneable<GetUnlockTeleportCsReq>, IBufferMessage
	{
		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06005DFB RID: 24059 RVA: 0x000F908C File Offset: 0x000F728C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetUnlockTeleportCsReq> Parser
		{
			get
			{
				return GetUnlockTeleportCsReq._parser;
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06005DFC RID: 24060 RVA: 0x000F9093 File Offset: 0x000F7293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetUnlockTeleportCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x000F90A5 File Offset: 0x000F72A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetUnlockTeleportCsReq.Descriptor;
			}
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x000F90AC File Offset: 0x000F72AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportCsReq()
		{
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x000F90BF File Offset: 0x000F72BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportCsReq(GetUnlockTeleportCsReq other) : this()
		{
			this.entryIdList_ = other.entryIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x000F90E9 File Offset: 0x000F72E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetUnlockTeleportCsReq Clone()
		{
			return new GetUnlockTeleportCsReq(this);
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06005E01 RID: 24065 RVA: 0x000F90F1 File Offset: 0x000F72F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EntryIdList
		{
			get
			{
				return this.entryIdList_;
			}
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x000F90F9 File Offset: 0x000F72F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetUnlockTeleportCsReq);
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x000F9107 File Offset: 0x000F7307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetUnlockTeleportCsReq other)
		{
			return other != null && (other == this || (this.entryIdList_.Equals(other.entryIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x000F913C File Offset: 0x000F733C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entryIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x000F9170 File Offset: 0x000F7370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x000F9178 File Offset: 0x000F7378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x000F9181 File Offset: 0x000F7381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entryIdList_.WriteTo(ref output, GetUnlockTeleportCsReq._repeated_entryIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x000F91A8 File Offset: 0x000F73A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entryIdList_.CalculateSize(GetUnlockTeleportCsReq._repeated_entryIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x000F91E1 File Offset: 0x000F73E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetUnlockTeleportCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.entryIdList_.Add(other.entryIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x000F920F File Offset: 0x000F740F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x000F9218 File Offset: 0x000F7418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entryIdList_.AddEntriesFrom(ref input, GetUnlockTeleportCsReq._repeated_entryIdList_codec);
				}
			}
		}

		// Token: 0x0400243C RID: 9276
		private static readonly MessageParser<GetUnlockTeleportCsReq> _parser = new MessageParser<GetUnlockTeleportCsReq>(() => new GetUnlockTeleportCsReq());

		// Token: 0x0400243D RID: 9277
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400243E RID: 9278
		public const int EntryIdListFieldNumber = 4;

		// Token: 0x0400243F RID: 9279
		private static readonly FieldCodec<uint> _repeated_entryIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04002440 RID: 9280
		private readonly RepeatedField<uint> entryIdList_ = new RepeatedField<uint>();
	}
}
