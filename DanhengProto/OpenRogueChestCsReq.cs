using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C6B RID: 3179
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OpenRogueChestCsReq : IMessage<OpenRogueChestCsReq>, IMessage, IEquatable<OpenRogueChestCsReq>, IDeepCloneable<OpenRogueChestCsReq>, IBufferMessage
	{
		// Token: 0x170027B1 RID: 10161
		// (get) Token: 0x06008D46 RID: 36166 RVA: 0x001757E5 File Offset: 0x001739E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OpenRogueChestCsReq> Parser
		{
			get
			{
				return OpenRogueChestCsReq._parser;
			}
		}

		// Token: 0x170027B2 RID: 10162
		// (get) Token: 0x06008D47 RID: 36167 RVA: 0x001757EC File Offset: 0x001739EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OpenRogueChestCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027B3 RID: 10163
		// (get) Token: 0x06008D48 RID: 36168 RVA: 0x001757FE File Offset: 0x001739FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OpenRogueChestCsReq.Descriptor;
			}
		}

		// Token: 0x06008D49 RID: 36169 RVA: 0x00175805 File Offset: 0x00173A05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestCsReq()
		{
		}

		// Token: 0x06008D4A RID: 36170 RVA: 0x0017580D File Offset: 0x00173A0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestCsReq(OpenRogueChestCsReq other) : this()
		{
			this.hODGFGACFKC_ = other.hODGFGACFKC_;
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D4B RID: 36171 RVA: 0x0017583E File Offset: 0x00173A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OpenRogueChestCsReq Clone()
		{
			return new OpenRogueChestCsReq(this);
		}

		// Token: 0x170027B4 RID: 10164
		// (get) Token: 0x06008D4C RID: 36172 RVA: 0x00175846 File Offset: 0x00173A46
		// (set) Token: 0x06008D4D RID: 36173 RVA: 0x0017584E File Offset: 0x00173A4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HODGFGACFKC
		{
			get
			{
				return this.hODGFGACFKC_;
			}
			set
			{
				this.hODGFGACFKC_ = value;
			}
		}

		// Token: 0x170027B5 RID: 10165
		// (get) Token: 0x06008D4E RID: 36174 RVA: 0x00175857 File Offset: 0x00173A57
		// (set) Token: 0x06008D4F RID: 36175 RVA: 0x0017585F File Offset: 0x00173A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06008D50 RID: 36176 RVA: 0x00175868 File Offset: 0x00173A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OpenRogueChestCsReq);
		}

		// Token: 0x06008D51 RID: 36177 RVA: 0x00175876 File Offset: 0x00173A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OpenRogueChestCsReq other)
		{
			return other != null && (other == this || (this.HODGFGACFKC == other.HODGFGACFKC && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008D52 RID: 36178 RVA: 0x001758B4 File Offset: 0x00173AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HODGFGACFKC)
			{
				num ^= this.HODGFGACFKC.GetHashCode();
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D53 RID: 36179 RVA: 0x0017590C File Offset: 0x00173B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D54 RID: 36180 RVA: 0x00175914 File Offset: 0x00173B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D55 RID: 36181 RVA: 0x00175920 File Offset: 0x00173B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HODGFGACFKC)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.HODGFGACFKC);
			}
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D56 RID: 36182 RVA: 0x0017597C File Offset: 0x00173B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HODGFGACFKC)
			{
				num += 2;
			}
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D57 RID: 36183 RVA: 0x001759C8 File Offset: 0x00173BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OpenRogueChestCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HODGFGACFKC)
			{
				this.HODGFGACFKC = other.HODGFGACFKC;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008D58 RID: 36184 RVA: 0x00175A18 File Offset: 0x00173C18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D59 RID: 36185 RVA: 0x00175A24 File Offset: 0x00173C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InteractedPropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.HODGFGACFKC = input.ReadBool();
				}
			}
		}

		// Token: 0x04003646 RID: 13894
		private static readonly MessageParser<OpenRogueChestCsReq> _parser = new MessageParser<OpenRogueChestCsReq>(() => new OpenRogueChestCsReq());

		// Token: 0x04003647 RID: 13895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003648 RID: 13896
		public const int HODGFGACFKCFieldNumber = 3;

		// Token: 0x04003649 RID: 13897
		private bool hODGFGACFKC_;

		// Token: 0x0400364A RID: 13898
		public const int InteractedPropEntityIdFieldNumber = 12;

		// Token: 0x0400364B RID: 13899
		private uint interactedPropEntityId_;
	}
}
