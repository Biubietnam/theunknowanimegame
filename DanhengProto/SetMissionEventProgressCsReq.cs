using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001115 RID: 4373
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetMissionEventProgressCsReq : IMessage<SetMissionEventProgressCsReq>, IMessage, IEquatable<SetMissionEventProgressCsReq>, IDeepCloneable<SetMissionEventProgressCsReq>, IBufferMessage
	{
		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600C2FD RID: 49917 RVA: 0x0020B87D File Offset: 0x00209A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetMissionEventProgressCsReq> Parser
		{
			get
			{
				return SetMissionEventProgressCsReq._parser;
			}
		}

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600C2FE RID: 49918 RVA: 0x0020B884 File Offset: 0x00209A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetMissionEventProgressCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600C2FF RID: 49919 RVA: 0x0020B896 File Offset: 0x00209A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetMissionEventProgressCsReq.Descriptor;
			}
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x0020B89D File Offset: 0x00209A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressCsReq()
		{
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x0020B8A5 File Offset: 0x00209AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressCsReq(SetMissionEventProgressCsReq other) : this()
		{
			this.missionEventId_ = other.missionEventId_;
			this.progress_ = other.progress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x0020B8D6 File Offset: 0x00209AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetMissionEventProgressCsReq Clone()
		{
			return new SetMissionEventProgressCsReq(this);
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600C303 RID: 49923 RVA: 0x0020B8DE File Offset: 0x00209ADE
		// (set) Token: 0x0600C304 RID: 49924 RVA: 0x0020B8E6 File Offset: 0x00209AE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MissionEventId
		{
			get
			{
				return this.missionEventId_;
			}
			set
			{
				this.missionEventId_ = value;
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600C305 RID: 49925 RVA: 0x0020B8EF File Offset: 0x00209AEF
		// (set) Token: 0x0600C306 RID: 49926 RVA: 0x0020B8F7 File Offset: 0x00209AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x0020B900 File Offset: 0x00209B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetMissionEventProgressCsReq);
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x0020B90E File Offset: 0x00209B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetMissionEventProgressCsReq other)
		{
			return other != null && (other == this || (this.MissionEventId == other.MissionEventId && this.Progress == other.Progress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x0020B94C File Offset: 0x00209B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MissionEventId != 0U)
			{
				num ^= this.MissionEventId.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x0020B9A4 File Offset: 0x00209BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C30B RID: 49931 RVA: 0x0020B9AC File Offset: 0x00209BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x0020B9B8 File Offset: 0x00209BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Progress != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Progress);
			}
			if (this.MissionEventId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x0020BA14 File Offset: 0x00209C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MissionEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MissionEventId);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x0020BA6C File Offset: 0x00209C6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetMissionEventProgressCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MissionEventId != 0U)
			{
				this.MissionEventId = other.MissionEventId;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C30F RID: 49935 RVA: 0x0020BABC File Offset: 0x00209CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x0020BAC8 File Offset: 0x00209CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MissionEventId = input.ReadUInt32();
					}
				}
				else
				{
					this.Progress = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004ED2 RID: 20178
		private static readonly MessageParser<SetMissionEventProgressCsReq> _parser = new MessageParser<SetMissionEventProgressCsReq>(() => new SetMissionEventProgressCsReq());

		// Token: 0x04004ED3 RID: 20179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ED4 RID: 20180
		public const int MissionEventIdFieldNumber = 4;

		// Token: 0x04004ED5 RID: 20181
		private uint missionEventId_;

		// Token: 0x04004ED6 RID: 20182
		public const int ProgressFieldNumber = 2;

		// Token: 0x04004ED7 RID: 20183
		private uint progress_;
	}
}
