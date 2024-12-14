using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A51 RID: 2641
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyQuitScRsp : IMessage<LobbyQuitScRsp>, IMessage, IEquatable<LobbyQuitScRsp>, IDeepCloneable<LobbyQuitScRsp>, IBufferMessage
	{
		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x06007519 RID: 29977 RVA: 0x00137214 File Offset: 0x00135414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyQuitScRsp> Parser
		{
			get
			{
				return LobbyQuitScRsp._parser;
			}
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600751A RID: 29978 RVA: 0x0013721B File Offset: 0x0013541B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyQuitScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600751B RID: 29979 RVA: 0x0013722D File Offset: 0x0013542D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyQuitScRsp.Descriptor;
			}
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x00137234 File Offset: 0x00135434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitScRsp()
		{
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x0013723C File Offset: 0x0013543C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitScRsp(LobbyQuitScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x00137261 File Offset: 0x00135461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyQuitScRsp Clone()
		{
			return new LobbyQuitScRsp(this);
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600751F RID: 29983 RVA: 0x00137269 File Offset: 0x00135469
		// (set) Token: 0x06007520 RID: 29984 RVA: 0x00137271 File Offset: 0x00135471
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

		// Token: 0x06007521 RID: 29985 RVA: 0x0013727A File Offset: 0x0013547A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyQuitScRsp);
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x00137288 File Offset: 0x00135488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyQuitScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x001372B8 File Offset: 0x001354B8
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

		// Token: 0x06007524 RID: 29988 RVA: 0x001372F7 File Offset: 0x001354F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x001372FF File Offset: 0x001354FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00137308 File Offset: 0x00135508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x0013733C File Offset: 0x0013553C
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

		// Token: 0x06007528 RID: 29992 RVA: 0x0013737A File Offset: 0x0013557A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyQuitScRsp other)
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

		// Token: 0x06007529 RID: 29993 RVA: 0x001373AB File Offset: 0x001355AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x001373B4 File Offset: 0x001355B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002D0F RID: 11535
		private static readonly MessageParser<LobbyQuitScRsp> _parser = new MessageParser<LobbyQuitScRsp>(() => new LobbyQuitScRsp());

		// Token: 0x04002D10 RID: 11536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D11 RID: 11537
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04002D12 RID: 11538
		private uint retcode_;
	}
}
