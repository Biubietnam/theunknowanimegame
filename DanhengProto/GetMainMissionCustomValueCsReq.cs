using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000709 RID: 1801
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMainMissionCustomValueCsReq : IMessage<GetMainMissionCustomValueCsReq>, IMessage, IEquatable<GetMainMissionCustomValueCsReq>, IDeepCloneable<GetMainMissionCustomValueCsReq>, IBufferMessage
	{
		// Token: 0x170016CF RID: 5839
		// (get) Token: 0x0600507E RID: 20606 RVA: 0x000D8F61 File Offset: 0x000D7161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMainMissionCustomValueCsReq> Parser
		{
			get
			{
				return GetMainMissionCustomValueCsReq._parser;
			}
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x000D8F68 File Offset: 0x000D7168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMainMissionCustomValueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x000D8F7A File Offset: 0x000D717A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMainMissionCustomValueCsReq.Descriptor;
			}
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x000D8F81 File Offset: 0x000D7181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueCsReq()
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x000D8F94 File Offset: 0x000D7194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueCsReq(GetMainMissionCustomValueCsReq other) : this()
		{
			this.mainMissionIdList_ = other.mainMissionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x000D8FBE File Offset: 0x000D71BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueCsReq Clone()
		{
			return new GetMainMissionCustomValueCsReq(this);
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x000D8FC6 File Offset: 0x000D71C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MainMissionIdList
		{
			get
			{
				return this.mainMissionIdList_;
			}
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x000D8FCE File Offset: 0x000D71CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMainMissionCustomValueCsReq);
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x000D8FDC File Offset: 0x000D71DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMainMissionCustomValueCsReq other)
		{
			return other != null && (other == this || (this.mainMissionIdList_.Equals(other.mainMissionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x000D9010 File Offset: 0x000D7210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mainMissionIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x000D9044 File Offset: 0x000D7244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x000D904C File Offset: 0x000D724C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x000D9055 File Offset: 0x000D7255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mainMissionIdList_.WriteTo(ref output, GetMainMissionCustomValueCsReq._repeated_mainMissionIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600508B RID: 20619 RVA: 0x000D907C File Offset: 0x000D727C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mainMissionIdList_.CalculateSize(GetMainMissionCustomValueCsReq._repeated_mainMissionIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600508C RID: 20620 RVA: 0x000D90B5 File Offset: 0x000D72B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMainMissionCustomValueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.mainMissionIdList_.Add(other.mainMissionIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600508D RID: 20621 RVA: 0x000D90E3 File Offset: 0x000D72E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600508E RID: 20622 RVA: 0x000D90EC File Offset: 0x000D72EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.mainMissionIdList_.AddEntriesFrom(ref input, GetMainMissionCustomValueCsReq._repeated_mainMissionIdList_codec);
				}
			}
		}

		// Token: 0x04001FA8 RID: 8104
		private static readonly MessageParser<GetMainMissionCustomValueCsReq> _parser = new MessageParser<GetMainMissionCustomValueCsReq>(() => new GetMainMissionCustomValueCsReq());

		// Token: 0x04001FA9 RID: 8105
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FAA RID: 8106
		public const int MainMissionIdListFieldNumber = 3;

		// Token: 0x04001FAB RID: 8107
		private static readonly FieldCodec<uint> _repeated_mainMissionIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04001FAC RID: 8108
		private readonly RepeatedField<uint> mainMissionIdList_ = new RepeatedField<uint>();
	}
}
