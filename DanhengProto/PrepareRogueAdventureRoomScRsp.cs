using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CFB RID: 3323
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrepareRogueAdventureRoomScRsp : IMessage<PrepareRogueAdventureRoomScRsp>, IMessage, IEquatable<PrepareRogueAdventureRoomScRsp>, IDeepCloneable<PrepareRogueAdventureRoomScRsp>, IBufferMessage
	{
		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x06009471 RID: 38001 RVA: 0x0018ABBB File Offset: 0x00188DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrepareRogueAdventureRoomScRsp> Parser
		{
			get
			{
				return PrepareRogueAdventureRoomScRsp._parser;
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x06009472 RID: 38002 RVA: 0x0018ABC2 File Offset: 0x00188DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrepareRogueAdventureRoomScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x06009473 RID: 38003 RVA: 0x0018ABD4 File Offset: 0x00188DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrepareRogueAdventureRoomScRsp.Descriptor;
			}
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x0018ABDB File Offset: 0x00188DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomScRsp()
		{
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x0018ABE4 File Offset: 0x00188DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomScRsp(PrepareRogueAdventureRoomScRsp other) : this()
		{
			this.adventureRoomInfo_ = ((other.adventureRoomInfo_ != null) ? other.adventureRoomInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009476 RID: 38006 RVA: 0x0018AC30 File Offset: 0x00188E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrepareRogueAdventureRoomScRsp Clone()
		{
			return new PrepareRogueAdventureRoomScRsp(this);
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x0018AC38 File Offset: 0x00188E38
		// (set) Token: 0x06009478 RID: 38008 RVA: 0x0018AC40 File Offset: 0x00188E40
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

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x0018AC49 File Offset: 0x00188E49
		// (set) Token: 0x0600947A RID: 38010 RVA: 0x0018AC51 File Offset: 0x00188E51
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

		// Token: 0x0600947B RID: 38011 RVA: 0x0018AC5A File Offset: 0x00188E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrepareRogueAdventureRoomScRsp);
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x0018AC68 File Offset: 0x00188E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrepareRogueAdventureRoomScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.AdventureRoomInfo, other.AdventureRoomInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600947D RID: 38013 RVA: 0x0018ACB8 File Offset: 0x00188EB8
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

		// Token: 0x0600947E RID: 38014 RVA: 0x0018AD0D File Offset: 0x00188F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x0018AD15 File Offset: 0x00188F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x0018AD20 File Offset: 0x00188F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this.adventureRoomInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x0018AD7C File Offset: 0x00188F7C
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

		// Token: 0x06009482 RID: 38018 RVA: 0x0018ADD4 File Offset: 0x00188FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrepareRogueAdventureRoomScRsp other)
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

		// Token: 0x06009483 RID: 38019 RVA: 0x0018AE3C File Offset: 0x0018903C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x0018AE48 File Offset: 0x00189048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 114U)
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

		// Token: 0x04003984 RID: 14724
		private static readonly MessageParser<PrepareRogueAdventureRoomScRsp> _parser = new MessageParser<PrepareRogueAdventureRoomScRsp>(() => new PrepareRogueAdventureRoomScRsp());

		// Token: 0x04003985 RID: 14725
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003986 RID: 14726
		public const int AdventureRoomInfoFieldNumber = 14;

		// Token: 0x04003987 RID: 14727
		private AdventureRoomInfo adventureRoomInfo_;

		// Token: 0x04003988 RID: 14728
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04003989 RID: 14729
		private uint retcode_;
	}
}
