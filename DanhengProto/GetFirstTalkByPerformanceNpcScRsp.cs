using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006AB RID: 1707
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetFirstTalkByPerformanceNpcScRsp : IMessage<GetFirstTalkByPerformanceNpcScRsp>, IMessage, IEquatable<GetFirstTalkByPerformanceNpcScRsp>, IDeepCloneable<GetFirstTalkByPerformanceNpcScRsp>, IBufferMessage
	{
		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x000CF4BB File Offset: 0x000CD6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetFirstTalkByPerformanceNpcScRsp> Parser
		{
			get
			{
				return GetFirstTalkByPerformanceNpcScRsp._parser;
			}
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06004C68 RID: 19560 RVA: 0x000CF4C2 File Offset: 0x000CD6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x000CF4D4 File Offset: 0x000CD6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetFirstTalkByPerformanceNpcScRsp.Descriptor;
			}
		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x000CF4DB File Offset: 0x000CD6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcScRsp()
		{
		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x000CF4EE File Offset: 0x000CD6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcScRsp(GetFirstTalkByPerformanceNpcScRsp other) : this()
		{
			this.npcMeetStatusList_ = other.npcMeetStatusList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x000CF524 File Offset: 0x000CD724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetFirstTalkByPerformanceNpcScRsp Clone()
		{
			return new GetFirstTalkByPerformanceNpcScRsp(this);
		}

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x000CF52C File Offset: 0x000CD72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcMeetByPerformanceStatus> NpcMeetStatusList
		{
			get
			{
				return this.npcMeetStatusList_;
			}
		}

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06004C6E RID: 19566 RVA: 0x000CF534 File Offset: 0x000CD734
		// (set) Token: 0x06004C6F RID: 19567 RVA: 0x000CF53C File Offset: 0x000CD73C
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

		// Token: 0x06004C70 RID: 19568 RVA: 0x000CF545 File Offset: 0x000CD745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetFirstTalkByPerformanceNpcScRsp);
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x000CF554 File Offset: 0x000CD754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetFirstTalkByPerformanceNpcScRsp other)
		{
			return other != null && (other == this || (this.npcMeetStatusList_.Equals(other.npcMeetStatusList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x000CF5A4 File Offset: 0x000CD7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npcMeetStatusList_.GetHashCode();
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

		// Token: 0x06004C73 RID: 19571 RVA: 0x000CF5F1 File Offset: 0x000CD7F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x000CF5F9 File Offset: 0x000CD7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x000CF604 File Offset: 0x000CD804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npcMeetStatusList_.WriteTo(ref output, GetFirstTalkByPerformanceNpcScRsp._repeated_npcMeetStatusList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x000CF654 File Offset: 0x000CD854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcMeetStatusList_.CalculateSize(GetFirstTalkByPerformanceNpcScRsp._repeated_npcMeetStatusList_codec);
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

		// Token: 0x06004C77 RID: 19575 RVA: 0x000CF6A8 File Offset: 0x000CD8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetFirstTalkByPerformanceNpcScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.npcMeetStatusList_.Add(other.npcMeetStatusList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x000CF6F5 File Offset: 0x000CD8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x000CF700 File Offset: 0x000CD900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 96U)
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
					this.npcMeetStatusList_.AddEntriesFrom(ref input, GetFirstTalkByPerformanceNpcScRsp._repeated_npcMeetStatusList_codec);
				}
			}
		}

		// Token: 0x04001E3D RID: 7741
		private static readonly MessageParser<GetFirstTalkByPerformanceNpcScRsp> _parser = new MessageParser<GetFirstTalkByPerformanceNpcScRsp>(() => new GetFirstTalkByPerformanceNpcScRsp());

		// Token: 0x04001E3E RID: 7742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001E3F RID: 7743
		public const int NpcMeetStatusListFieldNumber = 6;

		// Token: 0x04001E40 RID: 7744
		private static readonly FieldCodec<NpcMeetByPerformanceStatus> _repeated_npcMeetStatusList_codec = FieldCodec.ForMessage<NpcMeetByPerformanceStatus>(50U, NpcMeetByPerformanceStatus.Parser);

		// Token: 0x04001E41 RID: 7745
		private readonly RepeatedField<NpcMeetByPerformanceStatus> npcMeetStatusList_ = new RepeatedField<NpcMeetByPerformanceStatus>();

		// Token: 0x04001E42 RID: 7746
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04001E43 RID: 7747
		private uint retcode_;
	}
}
