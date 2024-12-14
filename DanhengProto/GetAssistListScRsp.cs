using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000621 RID: 1569
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAssistListScRsp : IMessage<GetAssistListScRsp>, IMessage, IEquatable<GetAssistListScRsp>, IDeepCloneable<GetAssistListScRsp>, IBufferMessage
	{
		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06004656 RID: 18006 RVA: 0x000C07A1 File Offset: 0x000BE9A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAssistListScRsp> Parser
		{
			get
			{
				return GetAssistListScRsp._parser;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x000C07A8 File Offset: 0x000BE9A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAssistListScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06004658 RID: 18008 RVA: 0x000C07BA File Offset: 0x000BE9BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAssistListScRsp.Descriptor;
			}
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x000C07C1 File Offset: 0x000BE9C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListScRsp()
		{
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x000C07D4 File Offset: 0x000BE9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListScRsp(GetAssistListScRsp other) : this()
		{
			this.assistList_ = other.assistList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x000C080A File Offset: 0x000BEA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAssistListScRsp Clone()
		{
			return new GetAssistListScRsp(this);
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x0600465C RID: 18012 RVA: 0x000C0812 File Offset: 0x000BEA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerAssistInfo> AssistList
		{
			get
			{
				return this.assistList_;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x000C081A File Offset: 0x000BEA1A
		// (set) Token: 0x0600465E RID: 18014 RVA: 0x000C0822 File Offset: 0x000BEA22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x000C082B File Offset: 0x000BEA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAssistListScRsp);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x000C083C File Offset: 0x000BEA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAssistListScRsp other)
		{
			return other != null && (other == this || (this.assistList_.Equals(other.assistList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x000C088C File Offset: 0x000BEA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assistList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000C08D9 File Offset: 0x000BEAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x000C08E1 File Offset: 0x000BEAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x000C08EC File Offset: 0x000BEAEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.assistList_.WriteTo(ref output, GetAssistListScRsp._repeated_assistList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x000C093C File Offset: 0x000BEB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assistList_.CalculateSize(GetAssistListScRsp._repeated_assistList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x000C0990 File Offset: 0x000BEB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAssistListScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.assistList_.Add(other.assistList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x000C09DD File Offset: 0x000BEBDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x000C09E8 File Offset: 0x000BEBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.assistList_.AddEntriesFrom(ref input, GetAssistListScRsp._repeated_assistList_codec);
				}
			}
		}

		// Token: 0x04001C17 RID: 7191
		private static readonly MessageParser<GetAssistListScRsp> _parser = new MessageParser<GetAssistListScRsp>(() => new GetAssistListScRsp());

		// Token: 0x04001C18 RID: 7192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C19 RID: 7193
		public const int AssistListFieldNumber = 8;

		// Token: 0x04001C1A RID: 7194
		private static readonly FieldCodec<PlayerAssistInfo> _repeated_assistList_codec = FieldCodec.ForMessage<PlayerAssistInfo>(66U, PlayerAssistInfo.Parser);

		// Token: 0x04001C1B RID: 7195
		private readonly RepeatedField<PlayerAssistInfo> assistList_ = new RepeatedField<PlayerAssistInfo>();

		// Token: 0x04001C1C RID: 7196
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001C1D RID: 7197
		private uint retcode_;
	}
}
