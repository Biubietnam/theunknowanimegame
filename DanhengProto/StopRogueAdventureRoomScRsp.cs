using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E5 RID: 4581
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StopRogueAdventureRoomScRsp : IMessage<StopRogueAdventureRoomScRsp>, IMessage, IEquatable<StopRogueAdventureRoomScRsp>, IDeepCloneable<StopRogueAdventureRoomScRsp>, IBufferMessage
	{
		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x002255EB File Offset: 0x002237EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StopRogueAdventureRoomScRsp> Parser
		{
			get
			{
				return StopRogueAdventureRoomScRsp._parser;
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x002255F2 File Offset: 0x002237F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StopRogueAdventureRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600CCB5 RID: 52405 RVA: 0x00225604 File Offset: 0x00223804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopRogueAdventureRoomScRsp.Descriptor;
			}
		}

		// Token: 0x0600CCB6 RID: 52406 RVA: 0x0022560B File Offset: 0x0022380B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomScRsp()
		{
		}

		// Token: 0x0600CCB7 RID: 52407 RVA: 0x00225614 File Offset: 0x00223814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomScRsp(StopRogueAdventureRoomScRsp other) : this()
		{
			this.adventureRoomInfo_ = ((other.adventureRoomInfo_ != null) ? other.adventureRoomInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCB8 RID: 52408 RVA: 0x00225660 File Offset: 0x00223860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopRogueAdventureRoomScRsp Clone()
		{
			return new StopRogueAdventureRoomScRsp(this);
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600CCB9 RID: 52409 RVA: 0x00225668 File Offset: 0x00223868
		// (set) Token: 0x0600CCBA RID: 52410 RVA: 0x00225670 File Offset: 0x00223870
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

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x00225679 File Offset: 0x00223879
		// (set) Token: 0x0600CCBC RID: 52412 RVA: 0x00225681 File Offset: 0x00223881
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

		// Token: 0x0600CCBD RID: 52413 RVA: 0x0022568A File Offset: 0x0022388A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopRogueAdventureRoomScRsp);
		}

		// Token: 0x0600CCBE RID: 52414 RVA: 0x00225698 File Offset: 0x00223898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopRogueAdventureRoomScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.AdventureRoomInfo, other.AdventureRoomInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCBF RID: 52415 RVA: 0x002256E8 File Offset: 0x002238E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.adventureRoomInfo_ != null)
			{
				num ^= this.AdventureRoomInfo.GetHashCode();
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

		// Token: 0x0600CCC0 RID: 52416 RVA: 0x0022573D File Offset: 0x0022393D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CCC1 RID: 52417 RVA: 0x00225745 File Offset: 0x00223945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCC2 RID: 52418 RVA: 0x00225750 File Offset: 0x00223950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.adventureRoomInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCC3 RID: 52419 RVA: 0x002257AC File Offset: 0x002239AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.adventureRoomInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AdventureRoomInfo);
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

		// Token: 0x0600CCC4 RID: 52420 RVA: 0x00225804 File Offset: 0x00223A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopRogueAdventureRoomScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.adventureRoomInfo_ != null)
			{
				if (this.adventureRoomInfo_ == null)
				{
					this.AdventureRoomInfo = new AdventureRoomInfo();
				}
				this.AdventureRoomInfo.MergeFrom(other.AdventureRoomInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCC5 RID: 52421 RVA: 0x0022586C File Offset: 0x00223A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCC6 RID: 52422 RVA: 0x00225878 File Offset: 0x00223A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400528B RID: 21131
		private static readonly MessageParser<StopRogueAdventureRoomScRsp> _parser = new MessageParser<StopRogueAdventureRoomScRsp>(() => new StopRogueAdventureRoomScRsp());

		// Token: 0x0400528C RID: 21132
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400528D RID: 21133
		public const int AdventureRoomInfoFieldNumber = 8;

		// Token: 0x0400528E RID: 21134
		private AdventureRoomInfo adventureRoomInfo_;

		// Token: 0x0400528F RID: 21135
		public const int RetcodeFieldNumber = 2;

		// Token: 0x04005290 RID: 21136
		private uint retcode_;
	}
}
