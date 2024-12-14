using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB3 RID: 2995
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerGetFightGateScRsp : IMessage<MultiplayerGetFightGateScRsp>, IMessage, IEquatable<MultiplayerGetFightGateScRsp>, IDeepCloneable<MultiplayerGetFightGateScRsp>, IBufferMessage
	{
		// Token: 0x17002522 RID: 9506
		// (get) Token: 0x0600847A RID: 33914 RVA: 0x0015D8F3 File Offset: 0x0015BAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerGetFightGateScRsp> Parser
		{
			get
			{
				return MultiplayerGetFightGateScRsp._parser;
			}
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x0600847B RID: 33915 RVA: 0x0015D8FA File Offset: 0x0015BAFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerGetFightGateScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x0600847C RID: 33916 RVA: 0x0015D90C File Offset: 0x0015BB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerGetFightGateScRsp.Descriptor;
			}
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x0015D913 File Offset: 0x0015BB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateScRsp()
		{
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x0015D934 File Offset: 0x0015BB34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateScRsp(MultiplayerGetFightGateScRsp other) : this()
		{
			this.iPEPBMIKJCN_ = other.iPEPBMIKJCN_;
			this.port_ = other.port_;
			this.gCIGJDIMNCE_ = other.gCIGJDIMNCE_;
			this.ip_ = other.ip_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x0015D994 File Offset: 0x0015BB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerGetFightGateScRsp Clone()
		{
			return new MultiplayerGetFightGateScRsp(this);
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x06008480 RID: 33920 RVA: 0x0015D99C File Offset: 0x0015BB9C
		// (set) Token: 0x06008481 RID: 33921 RVA: 0x0015D9A4 File Offset: 0x0015BBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string IPEPBMIKJCN
		{
			get
			{
				return this.iPEPBMIKJCN_;
			}
			set
			{
				this.iPEPBMIKJCN_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002526 RID: 9510
		// (get) Token: 0x06008482 RID: 33922 RVA: 0x0015D9B7 File Offset: 0x0015BBB7
		// (set) Token: 0x06008483 RID: 33923 RVA: 0x0015D9BF File Offset: 0x0015BBBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Port
		{
			get
			{
				return this.port_;
			}
			set
			{
				this.port_ = value;
			}
		}

		// Token: 0x17002527 RID: 9511
		// (get) Token: 0x06008484 RID: 33924 RVA: 0x0015D9C8 File Offset: 0x0015BBC8
		// (set) Token: 0x06008485 RID: 33925 RVA: 0x0015D9D0 File Offset: 0x0015BBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ulong GCIGJDIMNCE
		{
			get
			{
				return this.gCIGJDIMNCE_;
			}
			set
			{
				this.gCIGJDIMNCE_ = value;
			}
		}

		// Token: 0x17002528 RID: 9512
		// (get) Token: 0x06008486 RID: 33926 RVA: 0x0015D9D9 File Offset: 0x0015BBD9
		// (set) Token: 0x06008487 RID: 33927 RVA: 0x0015D9E1 File Offset: 0x0015BBE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Ip
		{
			get
			{
				return this.ip_;
			}
			set
			{
				this.ip_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002529 RID: 9513
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x0015D9F4 File Offset: 0x0015BBF4
		// (set) Token: 0x06008489 RID: 33929 RVA: 0x0015D9FC File Offset: 0x0015BBFC
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

		// Token: 0x0600848A RID: 33930 RVA: 0x0015DA05 File Offset: 0x0015BC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerGetFightGateScRsp);
		}

		// Token: 0x0600848B RID: 33931 RVA: 0x0015DA14 File Offset: 0x0015BC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerGetFightGateScRsp other)
		{
			return other != null && (other == this || (!(this.IPEPBMIKJCN != other.IPEPBMIKJCN) && this.Port == other.Port && this.GCIGJDIMNCE == other.GCIGJDIMNCE && !(this.Ip != other.Ip) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600848C RID: 33932 RVA: 0x0015DA98 File Offset: 0x0015BC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IPEPBMIKJCN.Length != 0)
			{
				num ^= this.IPEPBMIKJCN.GetHashCode();
			}
			if (this.Port != 0U)
			{
				num ^= this.Port.GetHashCode();
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				num ^= this.GCIGJDIMNCE.GetHashCode();
			}
			if (this.Ip.Length != 0)
			{
				num ^= this.Ip.GetHashCode();
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

		// Token: 0x0600848D RID: 33933 RVA: 0x0015DB3F File Offset: 0x0015BD3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600848E RID: 33934 RVA: 0x0015DB47 File Offset: 0x0015BD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600848F RID: 33935 RVA: 0x0015DB50 File Offset: 0x0015BD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Ip.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Ip);
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.GCIGJDIMNCE);
			}
			if (this.Port != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Port);
			}
			if (this.IPEPBMIKJCN.Length != 0)
			{
				output.WriteRawTag(106);
				output.WriteString(this.IPEPBMIKJCN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008490 RID: 33936 RVA: 0x0015DC08 File Offset: 0x0015BE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IPEPBMIKJCN.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IPEPBMIKJCN);
			}
			if (this.Port != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Port);
			}
			if (this.GCIGJDIMNCE != 0UL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.GCIGJDIMNCE);
			}
			if (this.Ip.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Ip);
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

		// Token: 0x06008491 RID: 33937 RVA: 0x0015DCB0 File Offset: 0x0015BEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerGetFightGateScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IPEPBMIKJCN.Length != 0)
			{
				this.IPEPBMIKJCN = other.IPEPBMIKJCN;
			}
			if (other.Port != 0U)
			{
				this.Port = other.Port;
			}
			if (other.GCIGJDIMNCE != 0UL)
			{
				this.GCIGJDIMNCE = other.GCIGJDIMNCE;
			}
			if (other.Ip.Length != 0)
			{
				this.Ip = other.Ip;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008492 RID: 33938 RVA: 0x0015DD46 File Offset: 0x0015BF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008493 RID: 33939 RVA: 0x0015DD50 File Offset: 0x0015BF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 66U)
					{
						this.Ip = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.GCIGJDIMNCE = input.ReadUInt64();
						continue;
					}
					if (num == 88U)
					{
						this.Port = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						this.IPEPBMIKJCN = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040032B3 RID: 12979
		private static readonly MessageParser<MultiplayerGetFightGateScRsp> _parser = new MessageParser<MultiplayerGetFightGateScRsp>(() => new MultiplayerGetFightGateScRsp());

		// Token: 0x040032B4 RID: 12980
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B5 RID: 12981
		public const int IPEPBMIKJCNFieldNumber = 13;

		// Token: 0x040032B6 RID: 12982
		private string iPEPBMIKJCN_ = "";

		// Token: 0x040032B7 RID: 12983
		public const int PortFieldNumber = 11;

		// Token: 0x040032B8 RID: 12984
		private uint port_;

		// Token: 0x040032B9 RID: 12985
		public const int GCIGJDIMNCEFieldNumber = 9;

		// Token: 0x040032BA RID: 12986
		private ulong gCIGJDIMNCE_;

		// Token: 0x040032BB RID: 12987
		public const int IpFieldNumber = 8;

		// Token: 0x040032BC RID: 12988
		private string ip_ = "";

		// Token: 0x040032BD RID: 12989
		public const int RetcodeFieldNumber = 1;

		// Token: 0x040032BE RID: 12990
		private uint retcode_;
	}
}
