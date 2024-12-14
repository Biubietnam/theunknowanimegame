using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A49 RID: 2633
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyModifyPlayerInfoCsReq : IMessage<LobbyModifyPlayerInfoCsReq>, IMessage, IEquatable<LobbyModifyPlayerInfoCsReq>, IDeepCloneable<LobbyModifyPlayerInfoCsReq>, IBufferMessage
	{
		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x060074D6 RID: 29910 RVA: 0x0013690B File Offset: 0x00134B0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyModifyPlayerInfoCsReq> Parser
		{
			get
			{
				return LobbyModifyPlayerInfoCsReq._parser;
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x060074D7 RID: 29911 RVA: 0x00136912 File Offset: 0x00134B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyModifyPlayerInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x060074D8 RID: 29912 RVA: 0x00136924 File Offset: 0x00134B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyModifyPlayerInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060074D9 RID: 29913 RVA: 0x0013692B File Offset: 0x00134B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoCsReq()
		{
		}

		// Token: 0x060074DA RID: 29914 RVA: 0x00136934 File Offset: 0x00134B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoCsReq(LobbyModifyPlayerInfoCsReq other) : this()
		{
			this.type_ = other.type_;
			this.dIFNDEGMKNA_ = ((other.dIFNDEGMKNA_ != null) ? other.dIFNDEGMKNA_.Clone() : null);
			this.jAFCADJGPJH_ = other.jAFCADJGPJH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060074DB RID: 29915 RVA: 0x0013698C File Offset: 0x00134B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyPlayerInfoCsReq Clone()
		{
			return new LobbyModifyPlayerInfoCsReq(this);
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x060074DC RID: 29916 RVA: 0x00136994 File Offset: 0x00134B94
		// (set) Token: 0x060074DD RID: 29917 RVA: 0x0013699C File Offset: 0x00134B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyModifyType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x060074DE RID: 29918 RVA: 0x001369A5 File Offset: 0x00134BA5
		// (set) Token: 0x060074DF RID: 29919 RVA: 0x001369AD File Offset: 0x00134BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGDACNIBFMP DIFNDEGMKNA
		{
			get
			{
				return this.dIFNDEGMKNA_;
			}
			set
			{
				this.dIFNDEGMKNA_ = value;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x060074E0 RID: 29920 RVA: 0x001369B6 File Offset: 0x00134BB6
		// (set) Token: 0x060074E1 RID: 29921 RVA: 0x001369BE File Offset: 0x00134BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JAFCADJGPJH
		{
			get
			{
				return this.jAFCADJGPJH_;
			}
			set
			{
				this.jAFCADJGPJH_ = value;
			}
		}

		// Token: 0x060074E2 RID: 29922 RVA: 0x001369C7 File Offset: 0x00134BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyModifyPlayerInfoCsReq);
		}

		// Token: 0x060074E3 RID: 29923 RVA: 0x001369D8 File Offset: 0x00134BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyModifyPlayerInfoCsReq other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this.DIFNDEGMKNA, other.DIFNDEGMKNA) && this.JAFCADJGPJH == other.JAFCADJGPJH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060074E4 RID: 29924 RVA: 0x00136A38 File Offset: 0x00134C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != LobbyModifyType.None)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num ^= this.DIFNDEGMKNA.GetHashCode();
			}
			if (this.JAFCADJGPJH != 0U)
			{
				num ^= this.JAFCADJGPJH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060074E5 RID: 29925 RVA: 0x00136AAC File Offset: 0x00134CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060074E6 RID: 29926 RVA: 0x00136AB4 File Offset: 0x00134CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060074E7 RID: 29927 RVA: 0x00136AC0 File Offset: 0x00134CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JAFCADJGPJH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.JAFCADJGPJH);
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.DIFNDEGMKNA);
			}
			if (this.Type != LobbyModifyType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x00136B38 File Offset: 0x00134D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != LobbyModifyType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.dIFNDEGMKNA_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DIFNDEGMKNA);
			}
			if (this.JAFCADJGPJH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JAFCADJGPJH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x00136BA8 File Offset: 0x00134DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyModifyPlayerInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != LobbyModifyType.None)
			{
				this.Type = other.Type;
			}
			if (other.dIFNDEGMKNA_ != null)
			{
				if (this.dIFNDEGMKNA_ == null)
				{
					this.DIFNDEGMKNA = new PGDACNIBFMP();
				}
				this.DIFNDEGMKNA.MergeFrom(other.DIFNDEGMKNA);
			}
			if (other.JAFCADJGPJH != 0U)
			{
				this.JAFCADJGPJH = other.JAFCADJGPJH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060074EA RID: 29930 RVA: 0x00136C24 File Offset: 0x00134E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x00136C30 File Offset: 0x00134E30
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
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = (LobbyModifyType)input.ReadEnum();
						}
					}
					else
					{
						if (this.dIFNDEGMKNA_ == null)
						{
							this.DIFNDEGMKNA = new PGDACNIBFMP();
						}
						input.ReadMessage(this.DIFNDEGMKNA);
					}
				}
				else
				{
					this.JAFCADJGPJH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002CEC RID: 11500
		private static readonly MessageParser<LobbyModifyPlayerInfoCsReq> _parser = new MessageParser<LobbyModifyPlayerInfoCsReq>(() => new LobbyModifyPlayerInfoCsReq());

		// Token: 0x04002CED RID: 11501
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CEE RID: 11502
		public const int TypeFieldNumber = 13;

		// Token: 0x04002CEF RID: 11503
		private LobbyModifyType type_;

		// Token: 0x04002CF0 RID: 11504
		public const int DIFNDEGMKNAFieldNumber = 8;

		// Token: 0x04002CF1 RID: 11505
		private PGDACNIBFMP dIFNDEGMKNA_;

		// Token: 0x04002CF2 RID: 11506
		public const int JAFCADJGPJHFieldNumber = 2;

		// Token: 0x04002CF3 RID: 11507
		private uint jAFCADJGPJH_;
	}
}
