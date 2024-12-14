using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000417 RID: 1047
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnableRogueTalentScRsp : IMessage<EnableRogueTalentScRsp>, IMessage, IEquatable<EnableRogueTalentScRsp>, IDeepCloneable<EnableRogueTalentScRsp>, IBufferMessage
	{
		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000805A3 File Offset: 0x0007E7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnableRogueTalentScRsp> Parser
		{
			get
			{
				return EnableRogueTalentScRsp._parser;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002E7C RID: 11900 RVA: 0x000805AA File Offset: 0x0007E7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnableRogueTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000805BC File Offset: 0x0007E7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableRogueTalentScRsp.Descriptor;
			}
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000805C3 File Offset: 0x0007E7C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentScRsp()
		{
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000805CC File Offset: 0x0007E7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentScRsp(EnableRogueTalentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.talentInfoList_ = ((other.talentInfoList_ != null) ? other.talentInfoList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00080618 File Offset: 0x0007E818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableRogueTalentScRsp Clone()
		{
			return new EnableRogueTalentScRsp(this);
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x00080620 File Offset: 0x0007E820
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x00080628 File Offset: 0x0007E828
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

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x00080631 File Offset: 0x0007E831
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x00080639 File Offset: 0x0007E839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTalentInfoList TalentInfoList
		{
			get
			{
				return this.talentInfoList_;
			}
			set
			{
				this.talentInfoList_ = value;
			}
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x00080642 File Offset: 0x0007E842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableRogueTalentScRsp);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00080650 File Offset: 0x0007E850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableRogueTalentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.TalentInfoList, other.TalentInfoList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000806A0 File Offset: 0x0007E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.talentInfoList_ != null)
			{
				num ^= this.TalentInfoList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000806F5 File Offset: 0x0007E8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000806FD File Offset: 0x0007E8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00080708 File Offset: 0x0007E908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this.talentInfoList_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00080764 File Offset: 0x0007E964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.talentInfoList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TalentInfoList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000807BC File Offset: 0x0007E9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableRogueTalentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.talentInfoList_ != null)
			{
				if (this.talentInfoList_ == null)
				{
					this.TalentInfoList = new RogueTalentInfoList();
				}
				this.TalentInfoList.MergeFrom(other.TalentInfoList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00080824 File Offset: 0x0007EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00080830 File Offset: 0x0007EA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.talentInfoList_ == null)
						{
							this.TalentInfoList = new RogueTalentInfoList();
						}
						input.ReadMessage(this.TalentInfoList);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040012A8 RID: 4776
		private static readonly MessageParser<EnableRogueTalentScRsp> _parser = new MessageParser<EnableRogueTalentScRsp>(() => new EnableRogueTalentScRsp());

		// Token: 0x040012A9 RID: 4777
		private UnknownFieldSet _unknownFields;

		// Token: 0x040012AA RID: 4778
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040012AB RID: 4779
		private uint retcode_;

		// Token: 0x040012AC RID: 4780
		public const int TalentInfoListFieldNumber = 15;

		// Token: 0x040012AD RID: 4781
		private RogueTalentInfoList talentInfoList_;
	}
}
