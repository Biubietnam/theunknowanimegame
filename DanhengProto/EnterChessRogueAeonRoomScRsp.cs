using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200043D RID: 1085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterChessRogueAeonRoomScRsp : IMessage<EnterChessRogueAeonRoomScRsp>, IMessage, IEquatable<EnterChessRogueAeonRoomScRsp>, IDeepCloneable<EnterChessRogueAeonRoomScRsp>, IBufferMessage
	{
		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000845C3 File Offset: 0x000827C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterChessRogueAeonRoomScRsp> Parser
		{
			get
			{
				return EnterChessRogueAeonRoomScRsp._parser;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x000845CA File Offset: 0x000827CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterChessRogueAeonRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000845DC File Offset: 0x000827DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterChessRogueAeonRoomScRsp.Descriptor;
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000845E3 File Offset: 0x000827E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomScRsp()
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x000845EC File Offset: 0x000827EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomScRsp(EnterChessRogueAeonRoomScRsp other) : this()
		{
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x00084638 File Offset: 0x00082838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterChessRogueAeonRoomScRsp Clone()
		{
			return new EnterChessRogueAeonRoomScRsp(this);
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06003033 RID: 12339 RVA: 0x00084640 File Offset: 0x00082840
		// (set) Token: 0x06003034 RID: 12340 RVA: 0x00084648 File Offset: 0x00082848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003035 RID: 12341 RVA: 0x00084651 File Offset: 0x00082851
		// (set) Token: 0x06003036 RID: 12342 RVA: 0x00084659 File Offset: 0x00082859
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

		// Token: 0x06003037 RID: 12343 RVA: 0x00084662 File Offset: 0x00082862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterChessRogueAeonRoomScRsp);
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00084670 File Offset: 0x00082870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterChessRogueAeonRoomScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.StageInfo, other.StageInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x000846C0 File Offset: 0x000828C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
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

		// Token: 0x0600303A RID: 12346 RVA: 0x00084715 File Offset: 0x00082915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x0008471D File Offset: 0x0008291D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x00084728 File Offset: 0x00082928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.StageInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x00084784 File Offset: 0x00082984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
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

		// Token: 0x0600303E RID: 12350 RVA: 0x000847DC File Offset: 0x000829DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterChessRogueAeonRoomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600303F RID: 12351 RVA: 0x00084844 File Offset: 0x00082A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x00084850 File Offset: 0x00082A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400132C RID: 4908
		private static readonly MessageParser<EnterChessRogueAeonRoomScRsp> _parser = new MessageParser<EnterChessRogueAeonRoomScRsp>(() => new EnterChessRogueAeonRoomScRsp());

		// Token: 0x0400132D RID: 4909
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400132E RID: 4910
		public const int StageInfoFieldNumber = 15;

		// Token: 0x0400132F RID: 4911
		private ChessRogueInfo stageInfo_;

		// Token: 0x04001330 RID: 4912
		public const int RetcodeFieldNumber = 6;

		// Token: 0x04001331 RID: 4913
		private uint retcode_;
	}
}
