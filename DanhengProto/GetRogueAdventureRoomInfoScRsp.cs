using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007A3 RID: 1955
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueAdventureRoomInfoScRsp : IMessage<GetRogueAdventureRoomInfoScRsp>, IMessage, IEquatable<GetRogueAdventureRoomInfoScRsp>, IDeepCloneable<GetRogueAdventureRoomInfoScRsp>, IBufferMessage
	{
		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x0600574E RID: 22350 RVA: 0x000E9F1B File Offset: 0x000E811B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueAdventureRoomInfoScRsp> Parser
		{
			get
			{
				return GetRogueAdventureRoomInfoScRsp._parser;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x0600574F RID: 22351 RVA: 0x000E9F22 File Offset: 0x000E8122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueAdventureRoomInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06005750 RID: 22352 RVA: 0x000E9F34 File Offset: 0x000E8134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueAdventureRoomInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x000E9F3B File Offset: 0x000E813B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoScRsp()
		{
		}

		// Token: 0x06005752 RID: 22354 RVA: 0x000E9F44 File Offset: 0x000E8144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoScRsp(GetRogueAdventureRoomInfoScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.adventureRoomInfo_ = ((other.adventureRoomInfo_ != null) ? other.adventureRoomInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005753 RID: 22355 RVA: 0x000E9F90 File Offset: 0x000E8190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueAdventureRoomInfoScRsp Clone()
		{
			return new GetRogueAdventureRoomInfoScRsp(this);
		}

		// Token: 0x170018B1 RID: 6321
		// (get) Token: 0x06005754 RID: 22356 RVA: 0x000E9F98 File Offset: 0x000E8198
		// (set) Token: 0x06005755 RID: 22357 RVA: 0x000E9FA0 File Offset: 0x000E81A0
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

		// Token: 0x170018B2 RID: 6322
		// (get) Token: 0x06005756 RID: 22358 RVA: 0x000E9FA9 File Offset: 0x000E81A9
		// (set) Token: 0x06005757 RID: 22359 RVA: 0x000E9FB1 File Offset: 0x000E81B1
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

		// Token: 0x06005758 RID: 22360 RVA: 0x000E9FBA File Offset: 0x000E81BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueAdventureRoomInfoScRsp);
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x000E9FC8 File Offset: 0x000E81C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueAdventureRoomInfoScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.AdventureRoomInfo, other.AdventureRoomInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x000EA018 File Offset: 0x000E8218
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

		// Token: 0x0600575B RID: 22363 RVA: 0x000EA06D File Offset: 0x000E826D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x000EA075 File Offset: 0x000E8275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x000EA080 File Offset: 0x000E8280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			if (this.adventureRoomInfo_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.AdventureRoomInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x000EA0DC File Offset: 0x000E82DC
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

		// Token: 0x0600575F RID: 22367 RVA: 0x000EA134 File Offset: 0x000E8334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueAdventureRoomInfoScRsp other)
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

		// Token: 0x06005760 RID: 22368 RVA: 0x000EA19C File Offset: 0x000E839C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x000EA1A8 File Offset: 0x000E83A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 106U)
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

		// Token: 0x04002222 RID: 8738
		private static readonly MessageParser<GetRogueAdventureRoomInfoScRsp> _parser = new MessageParser<GetRogueAdventureRoomInfoScRsp>(() => new GetRogueAdventureRoomInfoScRsp());

		// Token: 0x04002223 RID: 8739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002224 RID: 8740
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04002225 RID: 8741
		private uint retcode_;

		// Token: 0x04002226 RID: 8742
		public const int AdventureRoomInfoFieldNumber = 13;

		// Token: 0x04002227 RID: 8743
		private AdventureRoomInfo adventureRoomInfo_;
	}
}
