using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013F5 RID: 5109
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UpdateRogueAdventureRoomScoreScRsp : IMessage<UpdateRogueAdventureRoomScoreScRsp>, IMessage, IEquatable<UpdateRogueAdventureRoomScoreScRsp>, IDeepCloneable<UpdateRogueAdventureRoomScoreScRsp>, IBufferMessage
	{
		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x0025DE1F File Offset: 0x0025C01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UpdateRogueAdventureRoomScoreScRsp> Parser
		{
			get
			{
				return UpdateRogueAdventureRoomScoreScRsp._parser;
			}
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x0025DE26 File Offset: 0x0025C026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UpdateRogueAdventureRoomScoreScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x0025DE38 File Offset: 0x0025C038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateRogueAdventureRoomScoreScRsp.Descriptor;
			}
		}

		// Token: 0x0600E3D1 RID: 58321 RVA: 0x0025DE3F File Offset: 0x0025C03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreScRsp()
		{
		}

		// Token: 0x0600E3D2 RID: 58322 RVA: 0x0025DE48 File Offset: 0x0025C048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreScRsp(UpdateRogueAdventureRoomScoreScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.adventureRoomInfo_ = ((other.adventureRoomInfo_ != null) ? other.adventureRoomInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E3D3 RID: 58323 RVA: 0x0025DE94 File Offset: 0x0025C094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateRogueAdventureRoomScoreScRsp Clone()
		{
			return new UpdateRogueAdventureRoomScoreScRsp(this);
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x0600E3D4 RID: 58324 RVA: 0x0025DE9C File Offset: 0x0025C09C
		// (set) Token: 0x0600E3D5 RID: 58325 RVA: 0x0025DEA4 File Offset: 0x0025C0A4
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

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x0600E3D6 RID: 58326 RVA: 0x0025DEAD File Offset: 0x0025C0AD
		// (set) Token: 0x0600E3D7 RID: 58327 RVA: 0x0025DEB5 File Offset: 0x0025C0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRoomInfo AdventureRoomInfo
		{
			get
			{
				return this.adventureRoomInfo_;
			}
			set
			{
				this.adventureRoomInfo_ = value;
			}
		}

		// Token: 0x0600E3D8 RID: 58328 RVA: 0x0025DEBE File Offset: 0x0025C0BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateRogueAdventureRoomScoreScRsp);
		}

		// Token: 0x0600E3D9 RID: 58329 RVA: 0x0025DECC File Offset: 0x0025C0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateRogueAdventureRoomScoreScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.AdventureRoomInfo, other.AdventureRoomInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E3DA RID: 58330 RVA: 0x0025DF1C File Offset: 0x0025C11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.adventureRoomInfo_ != null)
			{
				num ^= this.AdventureRoomInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E3DB RID: 58331 RVA: 0x0025DF71 File Offset: 0x0025C171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x0025DF79 File Offset: 0x0025C179
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x0025DF84 File Offset: 0x0025C184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.adventureRoomInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.AdventureRoomInfo);
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

		// Token: 0x0600E3DE RID: 58334 RVA: 0x0025DFE0 File Offset: 0x0025C1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.adventureRoomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x0025E038 File Offset: 0x0025C238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateRogueAdventureRoomScoreScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.adventureRoomInfo_ != null)
			{
				if (this.adventureRoomInfo_ == null)
				{
					this.AdventureRoomInfo = new AdventureRoomInfo();
				}
				this.AdventureRoomInfo.MergeFrom(other.AdventureRoomInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x0025E0A0 File Offset: 0x0025C2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E3E1 RID: 58337 RVA: 0x0025E0AC File Offset: 0x0025C2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
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
					if (this.adventureRoomInfo_ == null)
					{
						this.AdventureRoomInfo = new AdventureRoomInfo();
					}
					input.ReadMessage(this.AdventureRoomInfo);
				}
			}
		}

		// Token: 0x04005A8A RID: 23178
		private static readonly MessageParser<UpdateRogueAdventureRoomScoreScRsp> _parser = new MessageParser<UpdateRogueAdventureRoomScoreScRsp>(() => new UpdateRogueAdventureRoomScoreScRsp());

		// Token: 0x04005A8B RID: 23179
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A8C RID: 23180
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04005A8D RID: 23181
		private uint retcode_;

		// Token: 0x04005A8E RID: 23182
		public const int AdventureRoomInfoFieldNumber = 10;

		// Token: 0x04005A8F RID: 23183
		private AdventureRoomInfo adventureRoomInfo_;
	}
}
