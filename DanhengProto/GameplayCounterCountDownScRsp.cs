using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005DB RID: 1499
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameplayCounterCountDownScRsp : IMessage<GameplayCounterCountDownScRsp>, IMessage, IEquatable<GameplayCounterCountDownScRsp>, IDeepCloneable<GameplayCounterCountDownScRsp>, IBufferMessage
	{
		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x000B65BC File Offset: 0x000B47BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameplayCounterCountDownScRsp> Parser
		{
			get
			{
				return GameplayCounterCountDownScRsp._parser;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060042F3 RID: 17139 RVA: 0x000B65C3 File Offset: 0x000B47C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameplayCounterCountDownScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x000B65D5 File Offset: 0x000B47D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameplayCounterCountDownScRsp.Descriptor;
			}
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x000B65DC File Offset: 0x000B47DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownScRsp()
		{
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x000B65E4 File Offset: 0x000B47E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownScRsp(GameplayCounterCountDownScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x000B6609 File Offset: 0x000B4809
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameplayCounterCountDownScRsp Clone()
		{
			return new GameplayCounterCountDownScRsp(this);
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x000B6611 File Offset: 0x000B4811
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x000B6619 File Offset: 0x000B4819
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

		// Token: 0x060042FA RID: 17146 RVA: 0x000B6622 File Offset: 0x000B4822
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameplayCounterCountDownScRsp);
		}

		// Token: 0x060042FB RID: 17147 RVA: 0x000B6630 File Offset: 0x000B4830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameplayCounterCountDownScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042FC RID: 17148 RVA: 0x000B6660 File Offset: 0x000B4860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x060042FD RID: 17149 RVA: 0x000B669F File Offset: 0x000B489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x000B66A7 File Offset: 0x000B48A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x000B66B0 File Offset: 0x000B48B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x000B66E4 File Offset: 0x000B48E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06004301 RID: 17153 RVA: 0x000B6722 File Offset: 0x000B4922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameplayCounterCountDownScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x000B6753 File Offset: 0x000B4953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x000B675C File Offset: 0x000B495C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A96 RID: 6806
		private static readonly MessageParser<GameplayCounterCountDownScRsp> _parser = new MessageParser<GameplayCounterCountDownScRsp>(() => new GameplayCounterCountDownScRsp());

		// Token: 0x04001A97 RID: 6807
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A98 RID: 6808
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001A99 RID: 6809
		private uint retcode_;
	}
}
