using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A79 RID: 2681
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MakeDrinkScRsp : IMessage<MakeDrinkScRsp>, IMessage, IEquatable<MakeDrinkScRsp>, IDeepCloneable<MakeDrinkScRsp>, IBufferMessage
	{
		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x060076CE RID: 30414 RVA: 0x0013B3FC File Offset: 0x001395FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MakeDrinkScRsp> Parser
		{
			get
			{
				return MakeDrinkScRsp._parser;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x060076CF RID: 30415 RVA: 0x0013B403 File Offset: 0x00139603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MakeDrinkScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x060076D0 RID: 30416 RVA: 0x0013B415 File Offset: 0x00139615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MakeDrinkScRsp.Descriptor;
			}
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x0013B41C File Offset: 0x0013961C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkScRsp()
		{
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x0013B424 File Offset: 0x00139624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkScRsp(MakeDrinkScRsp other) : this()
		{
			this.nextChatId_ = other.nextChatId_;
			this.isSucc_ = other.isSucc_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x0013B461 File Offset: 0x00139661
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MakeDrinkScRsp Clone()
		{
			return new MakeDrinkScRsp(this);
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x060076D4 RID: 30420 RVA: 0x0013B469 File Offset: 0x00139669
		// (set) Token: 0x060076D5 RID: 30421 RVA: 0x0013B471 File Offset: 0x00139671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NextChatId
		{
			get
			{
				return this.nextChatId_;
			}
			set
			{
				this.nextChatId_ = value;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x060076D6 RID: 30422 RVA: 0x0013B47A File Offset: 0x0013967A
		// (set) Token: 0x060076D7 RID: 30423 RVA: 0x0013B482 File Offset: 0x00139682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSucc
		{
			get
			{
				return this.isSucc_;
			}
			set
			{
				this.isSucc_ = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x060076D8 RID: 30424 RVA: 0x0013B48B File Offset: 0x0013968B
		// (set) Token: 0x060076D9 RID: 30425 RVA: 0x0013B493 File Offset: 0x00139693
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

		// Token: 0x060076DA RID: 30426 RVA: 0x0013B49C File Offset: 0x0013969C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MakeDrinkScRsp);
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x0013B4AC File Offset: 0x001396AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MakeDrinkScRsp other)
		{
			return other != null && (other == this || (this.NextChatId == other.NextChatId && this.IsSucc == other.IsSucc && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x0013B508 File Offset: 0x00139708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NextChatId != 0U)
			{
				num ^= this.NextChatId.GetHashCode();
			}
			if (this.IsSucc)
			{
				num ^= this.IsSucc.GetHashCode();
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

		// Token: 0x060076DD RID: 30429 RVA: 0x0013B579 File Offset: 0x00139779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x0013B581 File Offset: 0x00139781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x0013B58C File Offset: 0x0013978C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsSucc)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSucc);
			}
			if (this.NextChatId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.NextChatId);
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

		// Token: 0x060076E0 RID: 30432 RVA: 0x0013B604 File Offset: 0x00139804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NextChatId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextChatId);
			}
			if (this.IsSucc)
			{
				num += 2;
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

		// Token: 0x060076E1 RID: 30433 RVA: 0x0013B668 File Offset: 0x00139868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MakeDrinkScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NextChatId != 0U)
			{
				this.NextChatId = other.NextChatId;
			}
			if (other.IsSucc)
			{
				this.IsSucc = other.IsSucc;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x0013B6CC File Offset: 0x001398CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x0013B6D8 File Offset: 0x001398D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
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
						this.NextChatId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsSucc = input.ReadBool();
				}
			}
		}

		// Token: 0x04002DA6 RID: 11686
		private static readonly MessageParser<MakeDrinkScRsp> _parser = new MessageParser<MakeDrinkScRsp>(() => new MakeDrinkScRsp());

		// Token: 0x04002DA7 RID: 11687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DA8 RID: 11688
		public const int NextChatIdFieldNumber = 6;

		// Token: 0x04002DA9 RID: 11689
		private uint nextChatId_;

		// Token: 0x04002DAA RID: 11690
		public const int IsSuccFieldNumber = 4;

		// Token: 0x04002DAB RID: 11691
		private bool isSucc_;

		// Token: 0x04002DAC RID: 11692
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04002DAD RID: 11693
		private uint retcode_;
	}
}
