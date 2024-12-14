using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E05 RID: 3589
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueArcadeStartScRsp : IMessage<RogueArcadeStartScRsp>, IMessage, IEquatable<RogueArcadeStartScRsp>, IDeepCloneable<RogueArcadeStartScRsp>, IBufferMessage
	{
		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x001AE89F File Offset: 0x001ACA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueArcadeStartScRsp> Parser
		{
			get
			{
				return RogueArcadeStartScRsp._parser;
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x0600A078 RID: 41080 RVA: 0x001AE8A6 File Offset: 0x001ACAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueArcadeStartScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x001AE8B8 File Offset: 0x001ACAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueArcadeStartScRsp.Descriptor;
			}
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x001AE8BF File Offset: 0x001ACABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartScRsp()
		{
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x001AE8C8 File Offset: 0x001ACAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartScRsp(RogueArcadeStartScRsp other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x001AE920 File Offset: 0x001ACB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueArcadeStartScRsp Clone()
		{
			return new RogueArcadeStartScRsp(this);
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x001AE928 File Offset: 0x001ACB28
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x001AE930 File Offset: 0x001ACB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IKENAAJDAFF RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x17002D52 RID: 11602
		// (get) Token: 0x0600A07F RID: 41087 RVA: 0x001AE939 File Offset: 0x001ACB39
		// (set) Token: 0x0600A080 RID: 41088 RVA: 0x001AE941 File Offset: 0x001ACB41
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

		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x001AE94A File Offset: 0x001ACB4A
		// (set) Token: 0x0600A082 RID: 41090 RVA: 0x001AE952 File Offset: 0x001ACB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x001AE95B File Offset: 0x001ACB5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueArcadeStartScRsp);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x001AE96C File Offset: 0x001ACB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueArcadeStartScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && this.Retcode == other.Retcode && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x001AE9CC File Offset: 0x001ACBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x001AEA3A File Offset: 0x001ACC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x001AEA42 File Offset: 0x001ACC42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x001AEA4C File Offset: 0x001ACC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RoomId);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x001AEAC0 File Offset: 0x001ACCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x001AEB30 File Offset: 0x001ACD30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueArcadeStartScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new IKENAAJDAFF();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x001AEBAC File Offset: 0x001ACDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x001AEBB8 File Offset: 0x001ACDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 66U)
					{
						if (num != 120U)
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
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new IKENAAJDAFF();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
					}
				}
				else
				{
					this.RoomId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040041BA RID: 16826
		private static readonly MessageParser<RogueArcadeStartScRsp> _parser = new MessageParser<RogueArcadeStartScRsp>(() => new RogueArcadeStartScRsp());

		// Token: 0x040041BB RID: 16827
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041BC RID: 16828
		public const int RogueTournCurSceneInfoFieldNumber = 8;

		// Token: 0x040041BD RID: 16829
		private IKENAAJDAFF rogueTournCurSceneInfo_;

		// Token: 0x040041BE RID: 16830
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040041BF RID: 16831
		private uint retcode_;

		// Token: 0x040041C0 RID: 16832
		public const int RoomIdFieldNumber = 1;

		// Token: 0x040041C1 RID: 16833
		private uint roomId_;
	}
}
