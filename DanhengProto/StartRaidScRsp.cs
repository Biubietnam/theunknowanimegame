using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C3 RID: 4547
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartRaidScRsp : IMessage<StartRaidScRsp>, IMessage, IEquatable<StartRaidScRsp>, IDeepCloneable<StartRaidScRsp>, IBufferMessage
	{
		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600CB26 RID: 52006 RVA: 0x00221261 File Offset: 0x0021F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartRaidScRsp> Parser
		{
			get
			{
				return StartRaidScRsp._parser;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00221268 File Offset: 0x0021F468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartRaidScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600CB28 RID: 52008 RVA: 0x0022127A File Offset: 0x0021F47A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRaidScRsp.Descriptor;
			}
		}

		// Token: 0x0600CB29 RID: 52009 RVA: 0x00221281 File Offset: 0x0021F481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidScRsp()
		{
		}

		// Token: 0x0600CB2A RID: 52010 RVA: 0x0022128C File Offset: 0x0021F48C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidScRsp(StartRaidScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB2B RID: 52011 RVA: 0x002212D8 File Offset: 0x0021F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRaidScRsp Clone()
		{
			return new StartRaidScRsp(this);
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600CB2C RID: 52012 RVA: 0x002212E0 File Offset: 0x0021F4E0
		// (set) Token: 0x0600CB2D RID: 52013 RVA: 0x002212E8 File Offset: 0x0021F4E8
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

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600CB2E RID: 52014 RVA: 0x002212F1 File Offset: 0x0021F4F1
		// (set) Token: 0x0600CB2F RID: 52015 RVA: 0x002212F9 File Offset: 0x0021F4F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OIIOLCPBLCF Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x00221302 File Offset: 0x0021F502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRaidScRsp);
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x00221310 File Offset: 0x0021F510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRaidScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x00221360 File Offset: 0x0021F560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x002213B5 File Offset: 0x0021F5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x002213BD File Offset: 0x0021F5BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x002213C8 File Offset: 0x0021F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x00221424 File Offset: 0x0021F624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x0022147C File Offset: 0x0021F67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRaidScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new OIIOLCPBLCF();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x002214E4 File Offset: 0x0021F6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x002214F0 File Offset: 0x0021F6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.scene_ == null)
						{
							this.Scene = new OIIOLCPBLCF();
						}
						input.ReadMessage(this.Scene);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040051F0 RID: 20976
		private static readonly MessageParser<StartRaidScRsp> _parser = new MessageParser<StartRaidScRsp>(() => new StartRaidScRsp());

		// Token: 0x040051F1 RID: 20977
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051F2 RID: 20978
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040051F3 RID: 20979
		private uint retcode_;

		// Token: 0x040051F4 RID: 20980
		public const int SceneFieldNumber = 10;

		// Token: 0x040051F5 RID: 20981
		private OIIOLCPBLCF scene_;
	}
}
