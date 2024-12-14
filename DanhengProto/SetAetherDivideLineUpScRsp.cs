using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C7 RID: 4295
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetAetherDivideLineUpScRsp : IMessage<SetAetherDivideLineUpScRsp>, IMessage, IEquatable<SetAetherDivideLineUpScRsp>, IDeepCloneable<SetAetherDivideLineUpScRsp>, IBufferMessage
	{
		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x00203A4F File Offset: 0x00201C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetAetherDivideLineUpScRsp> Parser
		{
			get
			{
				return SetAetherDivideLineUpScRsp._parser;
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600BF85 RID: 49029 RVA: 0x00203A56 File Offset: 0x00201C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetAetherDivideLineUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x00203A68 File Offset: 0x00201C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAetherDivideLineUpScRsp.Descriptor;
			}
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x00203A6F File Offset: 0x00201C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpScRsp()
		{
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x00203A78 File Offset: 0x00201C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpScRsp(SetAetherDivideLineUpScRsp other) : this()
		{
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x00203AC4 File Offset: 0x00201CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetAetherDivideLineUpScRsp Clone()
		{
			return new SetAetherDivideLineUpScRsp(this);
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x00203ACC File Offset: 0x00201CCC
		// (set) Token: 0x0600BF8B RID: 49035 RVA: 0x00203AD4 File Offset: 0x00201CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideLineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600BF8C RID: 49036 RVA: 0x00203ADD File Offset: 0x00201CDD
		// (set) Token: 0x0600BF8D RID: 49037 RVA: 0x00203AE5 File Offset: 0x00201CE5
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

		// Token: 0x0600BF8E RID: 49038 RVA: 0x00203AEE File Offset: 0x00201CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAetherDivideLineUpScRsp);
		}

		// Token: 0x0600BF8F RID: 49039 RVA: 0x00203AFC File Offset: 0x00201CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetAetherDivideLineUpScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Lineup, other.Lineup) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x00203B4C File Offset: 0x00201D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
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

		// Token: 0x0600BF91 RID: 49041 RVA: 0x00203BA1 File Offset: 0x00201DA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x00203BA9 File Offset: 0x00201DA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x00203BB4 File Offset: 0x00201DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Lineup);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x00203C10 File Offset: 0x00201E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
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

		// Token: 0x0600BF95 RID: 49045 RVA: 0x00203C68 File Offset: 0x00201E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetAetherDivideLineUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new AetherDivideLineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x00203CD0 File Offset: 0x00201ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x00203CDC File Offset: 0x00201EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new AetherDivideLineupInfo();
						}
						input.ReadMessage(this.Lineup);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004DBD RID: 19901
		private static readonly MessageParser<SetAetherDivideLineUpScRsp> _parser = new MessageParser<SetAetherDivideLineUpScRsp>(() => new SetAetherDivideLineUpScRsp());

		// Token: 0x04004DBE RID: 19902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DBF RID: 19903
		public const int LineupFieldNumber = 14;

		// Token: 0x04004DC0 RID: 19904
		private AetherDivideLineupInfo lineup_;

		// Token: 0x04004DC1 RID: 19905
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04004DC2 RID: 19906
		private uint retcode_;
	}
}
