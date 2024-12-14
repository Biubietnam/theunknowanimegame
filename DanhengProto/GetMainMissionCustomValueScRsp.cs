using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200070B RID: 1803
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMainMissionCustomValueScRsp : IMessage<GetMainMissionCustomValueScRsp>, IMessage, IEquatable<GetMainMissionCustomValueScRsp>, IDeepCloneable<GetMainMissionCustomValueScRsp>, IBufferMessage
	{
		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06005092 RID: 20626 RVA: 0x000D91FF File Offset: 0x000D73FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMainMissionCustomValueScRsp> Parser
		{
			get
			{
				return GetMainMissionCustomValueScRsp._parser;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x000D9206 File Offset: 0x000D7406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMainMissionCustomValueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06005094 RID: 20628 RVA: 0x000D9218 File Offset: 0x000D7418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMainMissionCustomValueScRsp.Descriptor;
			}
		}

		// Token: 0x06005095 RID: 20629 RVA: 0x000D921F File Offset: 0x000D741F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueScRsp()
		{
		}

		// Token: 0x06005096 RID: 20630 RVA: 0x000D9232 File Offset: 0x000D7432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueScRsp(GetMainMissionCustomValueScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mainMissionList_ = other.mainMissionList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005097 RID: 20631 RVA: 0x000D9268 File Offset: 0x000D7468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMainMissionCustomValueScRsp Clone()
		{
			return new GetMainMissionCustomValueScRsp(this);
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06005098 RID: 20632 RVA: 0x000D9270 File Offset: 0x000D7470
		// (set) Token: 0x06005099 RID: 20633 RVA: 0x000D9278 File Offset: 0x000D7478
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

		// Token: 0x170016D8 RID: 5848
		// (get) Token: 0x0600509A RID: 20634 RVA: 0x000D9281 File Offset: 0x000D7481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainMission> MainMissionList
		{
			get
			{
				return this.mainMissionList_;
			}
		}

		// Token: 0x0600509B RID: 20635 RVA: 0x000D9289 File Offset: 0x000D7489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMainMissionCustomValueScRsp);
		}

		// Token: 0x0600509C RID: 20636 RVA: 0x000D9298 File Offset: 0x000D7498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMainMissionCustomValueScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.mainMissionList_.Equals(other.mainMissionList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600509D RID: 20637 RVA: 0x000D92E8 File Offset: 0x000D74E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.mainMissionList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600509E RID: 20638 RVA: 0x000D9335 File Offset: 0x000D7535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600509F RID: 20639 RVA: 0x000D933D File Offset: 0x000D753D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060050A0 RID: 20640 RVA: 0x000D9348 File Offset: 0x000D7548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mainMissionList_.WriteTo(ref output, GetMainMissionCustomValueScRsp._repeated_mainMissionList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060050A1 RID: 20641 RVA: 0x000D9398 File Offset: 0x000D7598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.mainMissionList_.CalculateSize(GetMainMissionCustomValueScRsp._repeated_mainMissionList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060050A2 RID: 20642 RVA: 0x000D93EC File Offset: 0x000D75EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMainMissionCustomValueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.mainMissionList_.Add(other.mainMissionList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060050A3 RID: 20643 RVA: 0x000D9439 File Offset: 0x000D7639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060050A4 RID: 20644 RVA: 0x000D9444 File Offset: 0x000D7644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 32U)
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
					this.mainMissionList_.AddEntriesFrom(ref input, GetMainMissionCustomValueScRsp._repeated_mainMissionList_codec);
				}
			}
		}

		// Token: 0x04001FAE RID: 8110
		private static readonly MessageParser<GetMainMissionCustomValueScRsp> _parser = new MessageParser<GetMainMissionCustomValueScRsp>(() => new GetMainMissionCustomValueScRsp());

		// Token: 0x04001FAF RID: 8111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB0 RID: 8112
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04001FB1 RID: 8113
		private uint retcode_;

		// Token: 0x04001FB2 RID: 8114
		public const int MainMissionListFieldNumber = 2;

		// Token: 0x04001FB3 RID: 8115
		private static readonly FieldCodec<MainMission> _repeated_mainMissionList_codec = FieldCodec.ForMessage<MainMission>(18U, MainMission.Parser);

		// Token: 0x04001FB4 RID: 8116
		private readonly RepeatedField<MainMission> mainMissionList_ = new RepeatedField<MainMission>();
	}
}
