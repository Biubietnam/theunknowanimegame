using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200071F RID: 1823
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionDataScRsp : IMessage<GetMissionDataScRsp>, IMessage, IEquatable<GetMissionDataScRsp>, IDeepCloneable<GetMissionDataScRsp>, IBufferMessage
	{
		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x000DB49F File Offset: 0x000D969F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionDataScRsp> Parser
		{
			get
			{
				return GetMissionDataScRsp._parser;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x000DB4A6 File Offset: 0x000D96A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x06005177 RID: 20855 RVA: 0x000DB4B8 File Offset: 0x000D96B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x000DB4BF File Offset: 0x000D96BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataScRsp()
		{
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x000DB4E0 File Offset: 0x000D96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataScRsp(GetMissionDataScRsp other) : this()
		{
			this.mCCMLJFOJID_ = other.mCCMLJFOJID_;
			this.missionList_ = other.missionList_.Clone();
			this.trackMissionId_ = other.trackMissionId_;
			this.mainMissionList_ = other.mainMissionList_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x000DB54A File Offset: 0x000D974A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionDataScRsp Clone()
		{
			return new GetMissionDataScRsp(this);
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x0600517B RID: 20859 RVA: 0x000DB552 File Offset: 0x000D9752
		// (set) Token: 0x0600517C RID: 20860 RVA: 0x000DB55A File Offset: 0x000D975A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MCCMLJFOJID
		{
			get
			{
				return this.mCCMLJFOJID_;
			}
			set
			{
				this.mCCMLJFOJID_ = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x0600517D RID: 20861 RVA: 0x000DB563 File Offset: 0x000D9763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> MissionList
		{
			get
			{
				return this.missionList_;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x000DB56B File Offset: 0x000D976B
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x000DB573 File Offset: 0x000D9773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TrackMissionId
		{
			get
			{
				return this.trackMissionId_;
			}
			set
			{
				this.trackMissionId_ = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x000DB57C File Offset: 0x000D977C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainMission> MainMissionList
		{
			get
			{
				return this.mainMissionList_;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x000DB584 File Offset: 0x000D9784
		// (set) Token: 0x06005182 RID: 20866 RVA: 0x000DB58C File Offset: 0x000D978C
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

		// Token: 0x06005183 RID: 20867 RVA: 0x000DB595 File Offset: 0x000D9795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionDataScRsp);
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x000DB5A4 File Offset: 0x000D97A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionDataScRsp other)
		{
			return other != null && (other == this || (this.MCCMLJFOJID == other.MCCMLJFOJID && this.missionList_.Equals(other.missionList_) && this.TrackMissionId == other.TrackMissionId && this.mainMissionList_.Equals(other.mainMissionList_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x000DB628 File Offset: 0x000D9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MCCMLJFOJID)
			{
				num ^= this.MCCMLJFOJID.GetHashCode();
			}
			num ^= this.missionList_.GetHashCode();
			if (this.TrackMissionId != 0U)
			{
				num ^= this.TrackMissionId.GetHashCode();
			}
			num ^= this.mainMissionList_.GetHashCode();
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

		// Token: 0x06005186 RID: 20870 RVA: 0x000DB6B5 File Offset: 0x000D98B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x000DB6BD File Offset: 0x000D98BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x000DB6C8 File Offset: 0x000D98C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrackMissionId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.TrackMissionId);
			}
			this.missionList_.WriteTo(ref output, GetMissionDataScRsp._repeated_missionList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.MCCMLJFOJID)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.MCCMLJFOJID);
			}
			this.mainMissionList_.WriteTo(ref output, GetMissionDataScRsp._repeated_mainMissionList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x000DB760 File Offset: 0x000D9960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MCCMLJFOJID)
			{
				num += 2;
			}
			num += this.missionList_.CalculateSize(GetMissionDataScRsp._repeated_missionList_codec);
			if (this.TrackMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TrackMissionId);
			}
			num += this.mainMissionList_.CalculateSize(GetMissionDataScRsp._repeated_mainMissionList_codec);
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

		// Token: 0x0600518A RID: 20874 RVA: 0x000DB7E8 File Offset: 0x000D99E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MCCMLJFOJID)
			{
				this.MCCMLJFOJID = other.MCCMLJFOJID;
			}
			this.missionList_.Add(other.missionList_);
			if (other.TrackMissionId != 0U)
			{
				this.TrackMissionId = other.TrackMissionId;
			}
			this.mainMissionList_.Add(other.mainMissionList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x000DB86E File Offset: 0x000D9A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x000DB878 File Offset: 0x000D9A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 24U)
					{
						this.TrackMissionId = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						this.missionList_.AddEntriesFrom(ref input, GetMissionDataScRsp._repeated_missionList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.MCCMLJFOJID = input.ReadBool();
						continue;
					}
					if (num == 122U)
					{
						this.mainMissionList_.AddEntriesFrom(ref input, GetMissionDataScRsp._repeated_mainMissionList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001FFF RID: 8191
		private static readonly MessageParser<GetMissionDataScRsp> _parser = new MessageParser<GetMissionDataScRsp>(() => new GetMissionDataScRsp());

		// Token: 0x04002000 RID: 8192
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002001 RID: 8193
		public const int MCCMLJFOJIDFieldNumber = 13;

		// Token: 0x04002002 RID: 8194
		private bool mCCMLJFOJID_;

		// Token: 0x04002003 RID: 8195
		public const int MissionListFieldNumber = 11;

		// Token: 0x04002004 RID: 8196
		private static readonly FieldCodec<Mission> _repeated_missionList_codec = FieldCodec.ForMessage<Mission>(90U, Mission.Parser);

		// Token: 0x04002005 RID: 8197
		private readonly RepeatedField<Mission> missionList_ = new RepeatedField<Mission>();

		// Token: 0x04002006 RID: 8198
		public const int TrackMissionIdFieldNumber = 3;

		// Token: 0x04002007 RID: 8199
		private uint trackMissionId_;

		// Token: 0x04002008 RID: 8200
		public const int MainMissionListFieldNumber = 15;

		// Token: 0x04002009 RID: 8201
		private static readonly FieldCodec<MainMission> _repeated_mainMissionList_codec = FieldCodec.ForMessage<MainMission>(122U, MainMission.Parser);

		// Token: 0x0400200A RID: 8202
		private readonly RepeatedField<MainMission> mainMissionList_ = new RepeatedField<MainMission>();

		// Token: 0x0400200B RID: 8203
		public const int RetcodeFieldNumber = 12;

		// Token: 0x0400200C RID: 8204
		private uint retcode_;
	}
}
