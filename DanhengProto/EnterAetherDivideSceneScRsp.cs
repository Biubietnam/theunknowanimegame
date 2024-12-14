using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000435 RID: 1077
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterAetherDivideSceneScRsp : IMessage<EnterAetherDivideSceneScRsp>, IMessage, IEquatable<EnterAetherDivideSceneScRsp>, IDeepCloneable<EnterAetherDivideSceneScRsp>, IBufferMessage
	{
		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x00083B69 File Offset: 0x00081D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterAetherDivideSceneScRsp> Parser
		{
			get
			{
				return EnterAetherDivideSceneScRsp._parser;
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x00083B70 File Offset: 0x00081D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterAetherDivideSceneScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x00083B82 File Offset: 0x00081D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAetherDivideSceneScRsp.Descriptor;
			}
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x00083B89 File Offset: 0x00081D89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneScRsp()
		{
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x00083B91 File Offset: 0x00081D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneScRsp(EnterAetherDivideSceneScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.kEFJAPJKMGC_ = other.kEFJAPJKMGC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00083BC2 File Offset: 0x00081DC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAetherDivideSceneScRsp Clone()
		{
			return new EnterAetherDivideSceneScRsp(this);
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x00083BCA File Offset: 0x00081DCA
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x00083BD2 File Offset: 0x00081DD2
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

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002FE1 RID: 12257 RVA: 0x00083BDB File Offset: 0x00081DDB
		// (set) Token: 0x06002FE2 RID: 12258 RVA: 0x00083BE3 File Offset: 0x00081DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KEFJAPJKMGC
		{
			get
			{
				return this.kEFJAPJKMGC_;
			}
			set
			{
				this.kEFJAPJKMGC_ = value;
			}
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00083BEC File Offset: 0x00081DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAetherDivideSceneScRsp);
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00083BFA File Offset: 0x00081DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAetherDivideSceneScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.KEFJAPJKMGC == other.KEFJAPJKMGC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00083C38 File Offset: 0x00081E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.KEFJAPJKMGC != 0U)
			{
				num ^= this.KEFJAPJKMGC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00083C90 File Offset: 0x00081E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00083C98 File Offset: 0x00081E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00083CA4 File Offset: 0x00081EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KEFJAPJKMGC != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.KEFJAPJKMGC);
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

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00083D00 File Offset: 0x00081F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.KEFJAPJKMGC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KEFJAPJKMGC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00083D58 File Offset: 0x00081F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAetherDivideSceneScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.KEFJAPJKMGC != 0U)
			{
				this.KEFJAPJKMGC = other.KEFJAPJKMGC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00083DA8 File Offset: 0x00081FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00083DB4 File Offset: 0x00081FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
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
					this.KEFJAPJKMGC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001318 RID: 4888
		private static readonly MessageParser<EnterAetherDivideSceneScRsp> _parser = new MessageParser<EnterAetherDivideSceneScRsp>(() => new EnterAetherDivideSceneScRsp());

		// Token: 0x04001319 RID: 4889
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400131A RID: 4890
		public const int RetcodeFieldNumber = 15;

		// Token: 0x0400131B RID: 4891
		private uint retcode_;

		// Token: 0x0400131C RID: 4892
		public const int KEFJAPJKMGCFieldNumber = 7;

		// Token: 0x0400131D RID: 4893
		private uint kEFJAPJKMGC_;
	}
}
