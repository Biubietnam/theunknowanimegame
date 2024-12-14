using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000595 RID: 1429
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishRogueCommonDialogueScRsp : IMessage<FinishRogueCommonDialogueScRsp>, IMessage, IEquatable<FinishRogueCommonDialogueScRsp>, IDeepCloneable<FinishRogueCommonDialogueScRsp>, IBufferMessage
	{
		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06003FC4 RID: 16324 RVA: 0x000ADD21 File Offset: 0x000ABF21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishRogueCommonDialogueScRsp> Parser
		{
			get
			{
				return FinishRogueCommonDialogueScRsp._parser;
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x000ADD28 File Offset: 0x000ABF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishRogueCommonDialogueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06003FC6 RID: 16326 RVA: 0x000ADD3A File Offset: 0x000ABF3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishRogueCommonDialogueScRsp.Descriptor;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x000ADD41 File Offset: 0x000ABF41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueScRsp()
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x000ADD49 File Offset: 0x000ABF49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueScRsp(FinishRogueCommonDialogueScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.eventUniqueId_ = other.eventUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x000ADD7A File Offset: 0x000ABF7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishRogueCommonDialogueScRsp Clone()
		{
			return new FinishRogueCommonDialogueScRsp(this);
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06003FCA RID: 16330 RVA: 0x000ADD82 File Offset: 0x000ABF82
		// (set) Token: 0x06003FCB RID: 16331 RVA: 0x000ADD8A File Offset: 0x000ABF8A
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

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06003FCC RID: 16332 RVA: 0x000ADD93 File Offset: 0x000ABF93
		// (set) Token: 0x06003FCD RID: 16333 RVA: 0x000ADD9B File Offset: 0x000ABF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x000ADDA4 File Offset: 0x000ABFA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishRogueCommonDialogueScRsp);
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x000ADDB2 File Offset: 0x000ABFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishRogueCommonDialogueScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.EventUniqueId == other.EventUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x000ADDF0 File Offset: 0x000ABFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x000ADE48 File Offset: 0x000AC048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x000ADE50 File Offset: 0x000AC050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x000ADE5C File Offset: 0x000AC05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FD4 RID: 16340 RVA: 0x000ADEB8 File Offset: 0x000AC0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x000ADF10 File Offset: 0x000AC110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishRogueCommonDialogueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x000ADF60 File Offset: 0x000AC160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x000ADF6C File Offset: 0x000AC16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EventUniqueId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001959 RID: 6489
		private static readonly MessageParser<FinishRogueCommonDialogueScRsp> _parser = new MessageParser<FinishRogueCommonDialogueScRsp>(() => new FinishRogueCommonDialogueScRsp());

		// Token: 0x0400195A RID: 6490
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400195B RID: 6491
		public const int RetcodeFieldNumber = 13;

		// Token: 0x0400195C RID: 6492
		private uint retcode_;

		// Token: 0x0400195D RID: 6493
		public const int EventUniqueIdFieldNumber = 15;

		// Token: 0x0400195E RID: 6494
		private uint eventUniqueId_;
	}
}
